using Cryptography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace CA
{
    public static class Model
    {        
        public static string login;
        public static string pass;
        public static string server;

        internal static void AliveClient(string data, string ip)
        {
            string goodData = ReadData(data, false);
            try
            {
                int.Parse(goodData);
                return; 
            }
            catch { }
            var masData = goodData.Split(' ');
            string guidClient = masData[0];
            int command = int.Parse(masData[1]);

            //TODA check dateTime
            if (command == 2)
            {
                DbConnector.SetStateClient(guidClient, "off");
                DeliveryRulesForServers(guidClient, ip, false);
                return;
            }
            bool rez = DbConnector.CheckStateClient(guidClient, ip);
            if (rez)
                DbConnector.ClientAlive(guidClient);
            else
            {
                DbConnector.SetStateClient(guidClient, "off");
                DeliveryRulesForServers(guidClient, ip, false);
            }

        }

        internal static void UpdateRulesServer(string ip)
        {
            SendRuleToServer(ip, "all", false);
        }

        private static void DeliveryRulesForServers(string clientGuid, string ipClient, bool rule = false)
        {
            string data;
            string[,] ports = DbConnector.GetPortsForClient(clientGuid);
            try
            {
                for (int i = 0; i < ports.GetUpperBound(0); i++)
                {
                    if (CheckServer(ports[i, 0]))
                    {
                        data = ipClient + ":" + ports[i, 1];
                        SendRuleToServer(ports[i, 0], data, rule);
                    }
                }
            }
            catch { }
        }

        private static bool CheckServer(string ip)
        {
            try
            {
                var conn = CreateWebServiceInstanceToServer(ip);
                return conn.IsAlive();
            }
            catch
            {
                return false;
            }
        }

        private static void SendRuleToServer(string ipSrv, string data, bool rule)
        {
            var conn = CreateWebServiceInstanceToServer(ipSrv);
            try
            {
                if (rule)
                {
                    conn.AddRule(data);
                }
                else
                    conn.DelRule(data);
            }
            catch
            {
                AddLog("Не успешная попытка передать на сервер данные об открытии\\закрытии портов");
            }
        }

        internal static void AliveServer(string data)
        {
            
        }

        static private string PrivateKeyCA
        {
            get
            {
                return Cryptography.Cryptography.DecryptAes(GetMyPrivateKey(), pass, login);
            }

        }

        public static string RegistrateClient(string data)
        {
            string goodData = ReadData(data);
            try
            {
                return int.Parse(goodData).ToString();
            }
            catch { }
            
            string returnData = "";
            string[] mas = goodData.Split(' ');
            if (int.Parse(mas[1]) == 1)
            {
                string guidUSB = mas[0];

                string guidClient = mas[3];
                Certificate certClient = Cryptography.Cryptography.CertificateFromString(mas[4]);
                certClient.dateStart = DateTime.Now;
                certClient.dateStop = DateTime.Now.AddMonths(2);
                certClient.dateCreating = DateTime.Now;
                //TODO: Check certificate   ***************************
                DbConnector.RegistrateClient(guidUSB, guidClient, certClient);
                Certificate certUsb = DbConnector.GetCertificate(guidUSB);
                string partKey = Cryptography.Cryptography.GenerateKey(50);
                DbConnector.SetPartKey(guidUSB, partKey);
                returnData = "6 SetPartKeyFromCA " + DateTime.Now + " " + partKey;
                returnData = returnData + " " + Cryptography.Cryptography.GetHash(returnData);
                returnData = returnData + " " + Cryptography.Cryptography.Sign(returnData, PrivateKeyCA);
                returnData = Cryptography.Cryptography.Encrypt(returnData, certUsb.publicKey);

                DbConnector.AddLogs("Регистрация клиента", "Зарегистрирован клинт: " + DbConnector.GetLoginClientByGuid(guidClient),TypeLog.normal);
            }
            return returnData;
        }

        internal static string RegistrateServer(string data)
        {
            string goodData = ReadData(data, false);
            try
            {
                return int.Parse(goodData).ToString();
            }
            catch { }
            string[] mas = goodData.Split(' ');
            int command = int.Parse(mas[1]);
            if (command == 1)
            {
                DbConnector.SetCertificateStatus(mas[0], "Active");
            }
            DbConnector.AddLogs("Регистрация сервера", "Зарегистрирован сервер: " + DbConnector.GetNameServerByGuid(mas[0]), TypeLog.normal);
            return "OK";
        }

        internal static string JoinClient(string data, string ip)
        {
            string goodData = ReadData(data, false);
            int num;
            if (Int32.TryParse(goodData, out num))
            {
                DbConnector.AddLogs("Попытка аутентификации клиента", "Попытка аутентификации клиента окончена с ошибкой: " + goodData, TypeLog.violation);
                return goodData;
            }
            string returnData = "";
            string[] mas = goodData.Split(' ');
            int command = int.Parse(mas[1]);
            switch (command)
            {
                case 1:
                    {
                        try
                        {
                            DbConnector.SetStateClient(mas[0], "auth", ip);
                            returnData = GenCheckData(goodData);
                        }
                        catch
                        {
                            Model.AddLog("Ошибка в Model.JoinClient event1");
                        }
                        break;
                    }
                case 2:
                    {
                        string guidUsb = mas[0];
                        string guidClient = DbConnector.GetGuidClientOfUsb(guidUsb);
                        string rezult = DbConnector.CheckTocken(mas[mas.Length-1], guidUsb);
                        if (rezult == "good")
                        {
                            DbConnector.SetStateClient(guidClient, "active", ip);

                            DeliveryRulesForServers(guidClient, ip, true);

                            returnData = "message was getted";

                            DbConnector.AddLogs("Успешная аутентификация клиента", "Успешная аутентификация клиента: " + DbConnector.GetLoginClientByGuid(guidClient), TypeLog.normal);
                        }
                        break;
                    }
                default:
                    {
                        DbConnector.AddLogs("Ошибка аутентификации клиента", "Не корректно указана команда аутентификации. Попытка аутентификации клиента: " + DbConnector.GetLoginClientByGuid(mas[0]), TypeLog.violation);
                        returnData = "fail_low";
                        break;
                    }
            }
            return returnData;
        }

        private static Server.SrvClient CreateWebServiceInstanceToServer(string address)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.SendTimeout = TimeSpan.FromMinutes(1);
            binding.OpenTimeout = TimeSpan.FromMinutes(1);
            binding.CloseTimeout = TimeSpan.FromMinutes(1);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);
            binding.AllowCookies = false;
            binding.BypassProxyOnLocal = false;
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.MessageEncoding = WSMessageEncoding.Text;
            binding.TextEncoding = Encoding.UTF8;
            binding.TransferMode = TransferMode.Buffered;
            binding.UseDefaultWebProxy = true;
            return new Server.SrvClient(binding, new EndpointAddress("http://" + address + ":46000/Server.Srv"));
        }

        internal static string JoinServer(string data)
        {
            string goodData = ReadData(data, false);
            int num;
            if (Int32.TryParse(goodData, out num))
            {
                DbConnector.AddLogs("Попытка аутентификации сервера", "Попытка аутентификации сервера окончена с ошибкой: " + goodData, TypeLog.violation);
                return goodData;
            }
            string[] mas = goodData.Split(' ');
            int command = int.Parse(mas[1]);
            if (command == 1)
            {
                string onlineClients = DbConnector.GetOnlineClientsForServer(mas[0]);
                string dataForSrv = "5 " + DateTime.Now + " " + onlineClients;
                dataForSrv = dataForSrv + " " + Cryptography.Cryptography.GetHash(dataForSrv);
                dataForSrv = dataForSrv + " " + Cryptography.Cryptography.Sign(dataForSrv, PrivateKeyCA);
                dataForSrv = Cryptography.Cryptography.Encrypt(dataForSrv, DbConnector.GetCertificate(mas[0]).publicKey);
                DbConnector.AddLogs("Аутентификация сервера", "Успешная аутентификация сервера: " + DbConnector.GetNameServerByGuid(mas[0]), TypeLog.normal);
                return dataForSrv;
            }
            else if (command == 2)
            {
                return "OK";
            }
            else
            {
                return "not OK";
            }
        }

        internal static void ChangeAdminPassword(string oldPass, string oldLogin, string newPass, string newLogin)
        {
            if (oldPass == pass)
            {
                DbConnector.AddLogs("Смена пароля администратора", "Происходт смена пароля администратора", TypeLog.smollViolation);
                string key = PrivateKeyCA;
                string value = Cryptography.Cryptography.EncryptAes(key, newPass, newLogin);
                DbConnector.UpdateValue(value, "privateKey");
                DbConnector.ChangePassword(newLogin, newPass);
            }

        }

        public static void AddLog(string log)
        {
            try
            {
                if (!EventLog.SourceExists("MyExampleService"))
                {
                    EventLog.CreateEventSource("MyExampleService", "MyExampleService");
                }
                EventLog.WriteEntry("MyExampleService", log, EventLogEntryType.Error, 228);
            }
            catch { }
        }

        private static string GenCheckData(string data)
        {
            string[] mas = data.Split(' ');
            string tocken = Guid.NewGuid().ToString();
            DbConnector.InsertTempGuid(tocken, mas[0]);
            string returnData = "6 NewTempTocken " + DateTime.Now + " " + tocken;
            returnData = returnData + " " + Cryptography.Cryptography.GetHash(returnData);
            returnData = returnData + " " + Cryptography.Cryptography.Sign(returnData, PrivateKeyCA);
            Certificate ClientCert = DbConnector.GetCertificate(mas[0]);
            Certificate UsbCert = DbConnector.GetCertificateUsbOfClient(mas[0]);
            returnData = Cryptography.Cryptography.Encrypt(returnData, UsbCert.publicKey);
            returnData = returnData.Replace(" ", "!!!!!");
            returnData = "7 RegistrateClient " + DateTime.Now + " " + DbConnector.GetPartKeyUsb(mas[0]) + " " + returnData;
            returnData = returnData + " " + Cryptography.Cryptography.GetHash(returnData);
            returnData = returnData + " " + Cryptography.Cryptography.Sign(returnData, PrivateKeyCA);
            returnData = Cryptography.Cryptography.Encrypt(returnData, ClientCert.publicKey);
            return returnData;
        }

        private static string ReadData(string data, bool usb = true)
        {
            string allEncriptData = Cryptography.Cryptography.Decrypt(data, PrivateKeyCA);
            string[] masData = allEncriptData.Split(' ');
            allEncriptData = null;
            try
            {
                if (!(int.Parse(masData[1]) == masData.Length))
                    return "1";

                string pubKey;
                if (usb)
                    pubKey = DbConnector.GetUSBCertificate(masData[0]).publicKey;
                else
                    pubKey = DbConnector.GetCertificate(masData[0]).publicKey;
                if (!(CheckSign(masData, pubKey)))
                    return "2";
                string rezultData = masData[2];
                for (int i = 3; i < int.Parse(masData[1]) - 2; i++)
                    rezultData += " " + masData[i];
                string dataForCheckHash = masData[0] + " " + masData[1] + " " + rezultData;
                if (!(Cryptography.Cryptography.GetHash(dataForCheckHash) == masData[masData.Length - 2]))
                    return "3";
                return masData[0] + " " + rezultData;
            }
            catch
            { AddLog("Ошибка в Model.ReadData"); return "444"; }
        }

        private static bool CheckSign(string[] masData, string pubKeyClient)
        {
            string dataForCheck = masData[0];
            for (int i = 1; i < masData.Length-1; i++)
            {
                dataForCheck += " " + masData[i];
            }
            bool rez = false;
            try
            {
                rez = Cryptography.Cryptography.CheckSign(dataForCheck, masData[masData.Length - 1], pubKeyClient);
            }
            catch { AddLog("Error in checkSign"); }
            return rez;
        }

        private static string GetMyPrivateKey()
        {
            string key = DbConnector.GetValue("privateKey");
            if (key == null)
            {
                AddLog("Поверждена база данных. Приложение будет остновлено");
                throw new Exception("Поверждена база данных. Приложение будет остновлено");
            }
            return key;
        }
        
    }
}
