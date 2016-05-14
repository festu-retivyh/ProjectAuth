using Cryptography;
using System;
using System.Collections.Generic;
using System.IO;

namespace CA
{
    static class Model
    {
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
            if (command==2)
                DbConnector.SetStateClient(guidClient, "off");
            bool rez = DbConnector.CheckStateClient(guidClient, ip);
            if(rez)
                DbConnector.ClientAlive(guidClient);
            else
                DbConnector.SetStateClient(guidClient, "off");

        }

        internal static void AliveServer(string data)
        {
            
        }
        static private string PrivateKeyCA
        {
            get
            {
                return GetMyPrivateKey();
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
            }
            return returnData;
        }

        internal static string RegistrateServer(string data)
        {
            string goodData = ReadData(data);
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
            return "OK";
        }

        //public static bool SearchGuidInList(List<objClient> list, string guid, )
        //{
        //    foreach (var l in list)
        //        if (l.guid == guid)
        //            return true;
        //    return false;
        //}

        internal static string JoinClient(string data, string ip)
        {
            string goodData = ReadData(data, false);
            try
            {
                return int.Parse(goodData).ToString();
            }
            catch { }
            string returnData = "";
            string[] mas = goodData.Split(' ');
            int command = int.Parse(mas[1]);
            switch (command)
            {
                case 1: { DbConnector.SetStateClient(mas[0], "auth", ip); returnData = GenCheckData(goodData); break; }
                case 2:
                    {
                        string guidUsb = goodData.Split(' ')[0];
                        string guidClient = DbConnector.GetGuidClientOfUsb(guidUsb);
                        //goodData = ReadData(goodData,false);
                        string rezult = DbConnector.CheckTocken(goodData.Split(' ')[goodData.Split(' ').Length-1], guidUsb);
                        
                        if (rezult == "good")
                        {
                            DbConnector.SetStateClient(guidClient, "active", ip);
                            //TODO:   Send message to Server  ***********************
                            returnData = "message was getted";
                        }
                        break;
                    }
                default:
                    {
                        returnData = "fail_low";
                        break;
                    }
            }
            return returnData;
        }
        
        internal static string JoinServer(string data)
        {
            string goodData = ReadData(data);
            try
            {
                return int.Parse(goodData).ToString();
            }
            catch { }
            string[] mas = goodData.Split(' ');
            int command = int.Parse(mas[1]);
            if (command == 1)
            {
                string onlineClients = DbConnector.GetOnlineClientsForServer(mas[0]);
                string dataForSrv = "5 " + DateTime.Now + " " + onlineClients + " ";
                dataForSrv = dataForSrv + " " + Cryptography.Cryptography.GetHash(dataForSrv);
                dataForSrv = dataForSrv + " " + Cryptography.Cryptography.Sign(dataForSrv, PrivateKeyCA);
                dataForSrv = Cryptography.Cryptography.Encrypt(dataForSrv, DbConnector.GetCertificate(mas[0]).publicKey);
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
            { return "differ error"; }
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
            catch { }
            return rez;
        }

        private static string GetMyPrivateKey()
        {
            return File.ReadAllText(@"D:\ca.key");
        }
        
    }
}
