using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace Server
{
    [RunInstaller(true)]
    public partial class InstallerClass : System.Configuration.Install.Installer
    {
        public InstallerClass()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            RegistrateServer();
        }

        public void RegistrateServer()
        {
            int zero = 0;
            string data = "";
            var disk = GetDirUsb();
            string dirUsb = disk.name + @"\srv.key";
            string curComp = infoAboutComputer();
            curComp = Cryptography.Cryptography.GetHash(curComp);
            if (!File.Exists(dirUsb))
                return;
            data = File.ReadAllText(dirUsb);

            string hashUsb = UsbSearcher.infoUsbGet(disk);
            for (int i = 0; i < 100; i++)
                hashUsb = Cryptography.Cryptography.GetHash(hashUsb);
            data = Cryptography.Cryptography.DecryptAes(data, hashUsb, DateTime.Now.ToString("dd:MM:yyyy"));
            var masData = data.Split(' ');
            string pubKeyCa="";
            try
            { pubKeyCa = masData[4];}
            catch
            { new Exception("Ошибка в зашифрованных данных, установка не может быть продолжена."); }
            if (!checkData(data, pubKeyCa))
                Console.WriteLine(4 / zero);                ////////ERRROR
            string DataForSave = masData[3] + masData[2] + masData[4] + masData[5];
            string dir = @"C:\ProgramData\ServerKey";
            Directory.CreateDirectory(dir);
            File.WriteAllText(dir + @"\srv.key", DataForSave);
            File.Encrypt(dir + @"\srv.key");
            string dataForSend = masData[3] + " 6 1 " + DateTime.Now;
            dataForSend = dataForSend + " " + Cryptography.Cryptography.GetHash(dataForSend);
            dataForSend = dataForSend + " " + Cryptography.Cryptography.Sign(dataForSend,masData[2]);

            dataForSend = Cryptography.Cryptography.Encrypt(dataForSend, pubKeyCa);
            data = Model.RegistrateToCA(dataForSend, masData[5]);
            if (data != "OK")
            {
                File.Delete(dir + @"\srv.key");
                Console.WriteLine(4 / zero);                ////////ERRROR
            }

        }

        private bool checkData(string data, string pubKeyCA)
        {
            var masData = data.Split(' ');
            if (int.Parse(masData[0]) != masData.Length)                //Check count section
                return false;
            data = masData[0];
            for (int i = 1; i < masData.Length - 2; i++)
                data = data + " " + masData[i];
            if (!Cryptography.Cryptography.CheckSign(data + " " + masData[masData.Length - 2], masData[masData.Length - 1], pubKeyCA))    //Check sign CA
                return false;
            if (Cryptography.Cryptography.GetHash(data) == masData[masData.Length - 2])     //Check hash data
                return true;
            return false;
        }

        private UsbDisk GetDirUsb()
        {
            var disk = UsbSearcher.getUsbAdapters()[0];
            return disk;
        }
        private string infoAboutComputer()
        {
            string data = "";

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["SerialNumber"] == null)
                    data += Cryptography.Cryptography.GetHash("None");
                else
                    data += Cryptography.Cryptography.GetHash(wmi_HD["SerialNumber"].ToString());
            }
            if (data == "")
                Cryptography.Cryptography.GetHash("IJ|lT1Tl|IJ");
            return data;
        }
    }
}
