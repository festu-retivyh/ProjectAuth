using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Management;
using System.ServiceModel;

namespace Client
{
    
    [RunInstaller(true)]
    public partial class InstallerClass : Installer
    {
        //string[] fileInst, fileUsb, fileClient;
        public string pin = "";
        public InstallerClass()
        {
            InitializeComponent();

        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            string dir = GetDirUsb();
            string dirUsb = dir + @"\prv.key";
            if (!File.Exists(dirUsb))
                return;
            StartInstallCert();
        }
        public void StartInstallCert()
        {
            InstallForm form = new InstallForm();
            form.FormClosing += Form_FormClosing;
            form.ShowDialog();
            RegistrateClient();
        } 
        internal static CAService.CAClient CreateWebServiceInstance()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            // I think most (or all) of these are defaults--I just copied them from app.config:
            binding.SendTimeout = TimeSpan.FromMinutes(1);
            binding.OpenTimeout = TimeSpan.FromMinutes(1);
            binding.CloseTimeout = TimeSpan.FromMinutes(1);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);
            binding.AllowCookies = false;
            binding.BypassProxyOnLocal = false;
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.MessageEncoding = WSMessageEncoding.Text;
            binding.TextEncoding = System.Text.Encoding.UTF8;
            binding.TransferMode = TransferMode.Buffered;
            binding.UseDefaultWebProxy = true;
            return new CAService.CAClient(binding, new EndpointAddress("http://192.168.68.100:45000/CA.CA"));
        }

        private void Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            pin = Cryptography.Cryptography.GetHash(((InstallForm)sender).pin);
        }

        public void RegistrateClient()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            string data = "";
            string dir = GetDirUsb();
            string dirUsb = dir + @"\prv.key";
            string curComp = infoAboutComputer();
            curComp = Cryptography.Cryptography.GetHash(curComp);
            if (!File.Exists(dirUsb))
                throw new Exception("Не найден файл с ключевой информацией на USB носителе.");
            data = File.ReadAllText(dirUsb);
            
            string hashUsb = UsbSearcher.infoUsbGet(UsbSearcher.getUsbAdapters()[0]);
            for (int i = 0; i < 100; i++)
                hashUsb = Cryptography.Cryptography.GetHash(hashUsb);
            data = Cryptography.Cryptography.DecryptAes(data, hashUsb, DateTime.Now.ToString("dd:MM:yyyy"));
            string pubKeyCA = data.Split(' ')[4];
            if (!checkData(data, pubKeyCA))
                throw new Exception("Не пройдена проверка файла.");
            string prvKeyClient = Cryptography.Cryptography.GeneratePrivateKey();
            Cryptography.sCertData dataCert = new Cryptography.sCertData();

            var certClient = Cryptography.Cryptography.GetCertificate(dataCert, prvKeyClient);
            string guidClient = Guid.NewGuid().ToString();
            //generate message for ca
            string guidUsb = data.Split(' ')[2];
            string dataForCA = guidUsb + " 8 1 " + DateTime.Now + " " + guidClient + " " + Cryptography.Cryptography.CertificateToString(certClient);
            dataForCA = dataForCA + " " + Cryptography.Cryptography.GetHash(dataForCA);
            dataForCA = dataForCA + " " + Cryptography.Cryptography.Sign(dataForCA, data.Split(' ')[3]);
            dataForCA = Cryptography.Cryptography.Encrypt(dataForCA, pubKeyCA);

            var instans = CreateWebServiceInstance();
            string dataFromCA = instans.RegistrateClient(new CAService.RegistrateClientRequest(dataForCA)).RegistrateClientResult;

            dataForCA = "";
            //read message from ca
            dataFromCA = Cryptography.Cryptography.Decrypt(dataFromCA, data.Split(' ')[3]);
            if (!checkData(dataFromCA, pubKeyCA))
                throw new Exception("Не пройденна проверка переданных данных в центре сертификации.");
            string partKeyCA = dataFromCA.Split(' ')[3];
            string partKeyClient = Cryptography.Cryptography.GenerateKey(50);
            //gen data for encript on usb
            string keyForSKey = GenerateKeyClient(partKeyCA, partKeyClient, pin);
            //encript private key USB
            string cryptUsbData = Cryptography.Cryptography.EncryptAes(guidUsb + " " + data.Split(' ')[3] + " " + data.Split(' ')[4], Model.genSKeyUsb(hashUsb,partKeyCA), hashUsb);
            cryptUsbData = cryptUsbData + " " + pubKeyCA;
            DeleteFile(dirUsb);
            try
            {
                DeleteFile(dir + @"\setup.exe");
                DeleteFile(dir + @"\Setup.msi");
            }
            catch { }
            File.WriteAllText(dir + @"\clnt.key", cryptUsbData);
            File.SetAttributes(dir + @"\clnt.key", FileAttributes.Hidden);
            //File.Encrypt(dir + @"\clnt.key");
            //gen data for encript on Client
            string sKeyClient = Cryptography.Cryptography.GenerateKey(100);
            string dataClient = prvKeyClient+ " " + guidClient+ " " + pubKeyCA;
            dataClient = Cryptography.Cryptography.EncryptAes(dataClient, sKeyClient, hashUsb);
            sKeyClient = Model.SetSKeyClient(sKeyClient, curComp, hashUsb, pin);
            //encript private key Client
            dataClient = dataClient + " " + sKeyClient + " " + pubKeyCA + " " + Cryptography.Cryptography.GetHash(hashUsb + curComp);
            string pathClient = @"C:\ProgramData\ClientKey";
            Directory.CreateDirectory(pathClient);
            File.WriteAllText(pathClient+@"\prv.key", dataClient);
            File.SetAttributes(pathClient + @"\prv.key", FileAttributes.Hidden);
            File.Encrypt(pathClient + @"\prv.key");
            if(File.Exists(Context.Parameters["targetdir"] + "Client.exe"))
                System.Diagnostics.Process.Start(Context.Parameters["targetdir"] + "Client.exe");
        }

        private void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
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

        private string GenerateKeyClient(string partKeyCA, string partKeyClient, string pin)
        {
            return partKeyCA + pin + partKeyClient;
        }

        private string GetDirUsb()
        {
            var disk = UsbSearcher.getUsbAdapters();
            return disk[0].name;
        }
        private bool checkData(string data, string pubKeyCA)
        {
            var masData = data.Split(' ');
            if (int.Parse(masData[0]) != masData.Length)                //Check count section
                return false;
            data = masData[0];
            for (int i = 1; i < masData.Length - 1; i++)
                data = data + " " + masData[i];
            if (!Cryptography.Cryptography.CheckSign(data, masData[masData.Length - 1], pubKeyCA))    //Check sign CA
                return false;
            data = masData[0];
            for (int i = 1; i < masData.Length - 2; i++)
                data = data + " " + masData[i];
            if (Cryptography.Cryptography.GetHash(data) == masData[masData.Length - 2])     //Check hash data
                return true;
            return false;
        }




       

    }
}
