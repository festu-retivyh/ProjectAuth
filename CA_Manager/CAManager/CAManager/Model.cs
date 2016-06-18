using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cryptography;
using System.Security.Cryptography;

namespace CAManager
{
    class Model
    {
        static private string privateKeyCA;
        public static event EventHandler UpdateViewTables;
        private static string pkey, ppin;

        static private string PrivateKeyCA
        {
            get
            {
                if (privateKeyCA == null)
                    privateKeyCA = GetMyPrivateKey();
                return privateKeyCA;
            }

        }
        public static void setParams(string v1, string v2)
        {
            pkey = v1;
            ppin = v2;
        }
        private static string GetMyPrivateKey()
        {
            string k = DbConnector.GetParam("privateKey");
            if (k == null)
                new ApplicationException("Ошибка при попытки получить приватный ключ центра сертификации");
            return Cryptography.Cryptography.DecryptAes(k, pkey, ppin);
        }

        internal static int MasterCreateCertificate(sCertData data, string domainName, UsbDisk disk)
        {
            int idUsb = CreatePesonCerificate(data, disk); //Создание сертификата добавление его в БД и сохранение его на юсб носитель
            sUSER user= new sUSER();
            user.login = data.login;
            user.domain = domainName;
            string[] fio = data.fioOwner.Split(new char[1] { ' ' });
            user.surname = fio[0];
            user.name = fio.Length > 1 ? fio[1] : "";
            user.patronymic = fio.Length==3?fio[2]:"";
            int idUser = DbConnector.addUser(user); //Добавляем в БД Юзера
            int idClient = DbConnector.AddClient(idUsb,idUser); //Добавляем в БД Клиента
            UpdateViewTables(true, new EventArgs());
            return idClient;
        }

        internal static void CallEventUpdateViewTables()
        {
            UpdateViewTables(true, new EventArgs());
        }

        internal static void SetProfileForClient(int clientId, int groupId)
        {
            int[] profiles = DbConnector.GetProfileForGroup(groupId);
            DbConnector.SetProfilesForClient(clientId, profiles);
        }

        internal static int CreatePesonCerificate(sCertData data, UsbDisk USB)
        {
            string pathToUSB = USB.name + "\\";
            string infoUSB = UsbSearcher.GetInfoUsb(USB);
            for (int i = 0; i < 100; i++)
            {
                infoUSB = Cryptography.Cryptography.GetHash(infoUSB);
            }
            
            string privateKey = Cryptography.Cryptography.GeneratePrivateKey();

            Certificate certificateUSB = Cryptography.Cryptography.GetCertificate(data, privateKey);
            certificateUSB.CalculateCertSign(PrivateKeyCA);
            //privateKey = Cryptography.Cryptography.EncryptAes(privateKey, infoUSB);
            int idCertificateUsb = DbConnector.AddCertificate(certificateUSB);
            string guidUsb = Guid.NewGuid().ToString();
            int idUsb = DbConnector.AddUsb( guidUsb, idCertificateUsb, infoUSB);
            string pubKeyCA = Cryptography.Cryptography.GetPublicKey(PrivateKeyCA);
            //TODO: Create files for INSTALL CLIENT
            //Добавляем setup проект в Client, копируем его как доп.файлы к этому проекту при развертывании
            //При выполнении текущего метода правим данные в нужных местах и копируем экзешник на флешку
            string pathFrom = Environment.CurrentDirectory + "\\client\\";
            File.Copy(pathFrom+ "setup.exe", pathToUSB+"Client.exe", true);
            File.Copy(pathFrom + "setup.msi", pathToUSB+"setup.msi", true);
            File.SetAttributes(pathToUSB + "setup.msi", FileAttributes.Hidden);
            string dataForUsb = "8 " + DateTime.Now + " " + guidUsb + " " + privateKey + " " + pubKeyCA + " " + Cryptography.Cryptography.Sign(guidUsb+ " " + privateKey, PrivateKeyCA);
            dataForUsb = dataForUsb + " " + Cryptography.Cryptography.GetHash(dataForUsb);
            dataForUsb = dataForUsb + " " + Cryptography.Cryptography.Sign(dataForUsb, PrivateKeyCA);
             
            File.WriteAllText(pathToUSB + "prv.key", Cryptography.Cryptography.EncryptAes(dataForUsb, infoUSB, DateTime.Now.ToString("dd:MM:yyyy")));
            File.SetAttributes(pathToUSB + "prv.key", FileAttributes.Hidden);
            return idUsb;
        }
        
        internal static int MasterAddServer(sSERVER server, UsbDisk disk)
        {

            string pathToUSB = disk.name + "\\";
            string privateKey = Cryptography.Cryptography.GeneratePrivateKey();

            string infoUSB = UsbSearcher.GetInfoUsb(disk);
            for (int i = 0; i < 100; i++)
            {
                infoUSB = Cryptography.Cryptography.GetHash(infoUSB);
            }

            sCertData certificate = new sCertData();
            certificate.dStart = server.dateStart;
            certificate.dStop = server.dateStop;
            certificate.fioOwner = server.address;
            certificate.login = server.name;
            Certificate certSrv = new Certificate(certificate, privateKey, 3);
            certSrv.CalculateCertSign(PrivateKeyCA);
            string sGuid = Guid.NewGuid().ToString();
            string dataForSrv = "8 " + DateTime.Now + " " + privateKey + " " + sGuid + " "
                + Cryptography.Cryptography.GetPublicKey(privateKeyCA) + " "
                + DbConnector.GetParam("AddressService");
            dataForSrv = dataForSrv + " " + Cryptography.Cryptography.GetHash(dataForSrv);
            dataForSrv = dataForSrv + " " + Cryptography.Cryptography.Sign(dataForSrv, privateKeyCA);
            File.WriteAllText(pathToUSB + @"\srv.key", Cryptography.Cryptography.EncryptAes(dataForSrv, infoUSB, DateTime.Now.ToString("dd:MM:yyyy")));
            string pathFrom = Environment.CurrentDirectory + "\\srv\\";
            File.Copy(pathFrom + "setup.exe", pathToUSB + "Server.exe", true);
            File.Copy(pathFrom + "setup.msi", pathToUSB + "SetupServer.msi", true);
            File.SetAttributes(pathToUSB + "SetupServer.msi", FileAttributes.Hidden);
            File.SetAttributes(pathToUSB + @"\srv.key", FileAttributes.Hidden);
            int idCertSrv = DbConnector.AddCertificate(certSrv);
            server.guid = sGuid;
            server.id = DbConnector.AddNewServer(server, idCertSrv);
            return server.id;
        }

        internal static string[] ReadFile(string path)
        {
            string[] data = null;
            try
            {
                data = new string[File.ReadAllLines(path).Length];
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    int i = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        data[i] = s;
                        i++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error 1: Read File");
            }
            return data;
        }

        internal static void OpenInfoAboutClient(int idSelUser)
        {
            sprClient form = new sprClient(idSelUser);
            form.Show();
        }
    }
}
