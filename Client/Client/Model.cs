
using System;
using System.IO;
using System.Management;
using System.ServiceModel;
using System.Text;

namespace Client
{
    static class Model
    {
        public static UsbDisk disk;
        public static string guidClient, pubKeyCA;
        internal static string hashPin;
        private static string messageForOffStatus = "";
        public static string genSKeyUsb(string a, string b = "", string c = "", string d = "")
        {
            return a + b + c + d;
        }

        internal static void SendAliveMessage(bool alive = true)
        {

            string data = "";
            if (disk != null)
            {
                var ca = CreateWebServiceInstance();
                if (alive)
                {
                    if (File.Exists(disk.name + @"\maan.key")) //Если имеется наш зашифрованный файл
                    {
                        var curUsb = UsbSearcher.infoUsbGet(disk);
                        var curComp = infoAboutComputer();
                        var fileUsb = File.ReadAllText(disk.name + @"\maan.key").Split(' ');
                        string hashUsb = curUsb;
                        for (int i = 0; i < 100; i++)
                            hashUsb = Cryptography.Cryptography.GetHash(hashUsb);
                        curComp = Cryptography.Cryptography.GetHash(curComp);

                        string[] fileClient = File.ReadAllText(@"C:\ProgramData\ClientKey\prv.key").Split(' ');
                        string HashSKeyClient = fileClient[3];
                        if (Cryptography.Cryptography.GetHash(hashUsb + curComp) != HashSKeyClient)
                            return;
                        string sKeyClient = GetSKeyClient(fileClient[1], curComp, hashUsb, hashPin);
                        string[] decriptDataClient = Cryptography.Cryptography.DecryptAes(fileClient[0], sKeyClient, hashUsb).Split(' ');
                        string privateKeyClient = decriptDataClient[0];
                        guidClient = decriptDataClient[1];
                        pubKeyCA = decriptDataClient[2];
                        ConstractorMessage cm = new ConstractorMessage();
                        data = cm.GetEncriptMessage(pubKeyCA, privateKeyClient, "1", guidClient);
                        if (messageForOffStatus == "")
                        {
                            messageForOffStatus = cm.GetEncriptMessage(pubKeyCA, privateKeyClient, "2", guidClient);
                        }
                        ca.AliveClient(new CAService.AliveClientRequest(data));
                    }
                }
                else
                {
                    ca.AliveClient(new CAService.AliveClientRequest(messageForOffStatus));
                }

            }
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
        private static string infoAboutComputer()
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
        public static string GetSKeyClient(string data, string curComp, string curUsb, string hashPin)
        {
            string key = GenSKey(data, curComp, curUsb, hashPin);
            string sKey = Cryptography.Cryptography.DecryptAes(data, key, hashPin);
            return sKey;
        }
        private static string GenSKey(string data, string curComp, string curUsb, string hashPin)
        {
            Encoding enc = Encoding.Unicode;
            byte[] a = enc.GetBytes(curComp);
            byte[] b = enc.GetBytes(curUsb);
            byte[] c = enc.GetBytes(hashPin);
            byte[] z = new byte[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                z[i] = (byte)(a[i] ^ b[i] ^ c[i]);      //найти минимальный массив байт и отталкиваться от него, а не от а
            }
            string key = enc.GetString(z);
            for (int i = 0; i < 100; i++)
            {
                key = Cryptography.Cryptography.GetHash(key);
            }
            File.WriteAllText(@"d:\sKey.txt", curComp +"|||"+ curUsb + "|||" + hashPin + "|||" + key);
            return key;
        }
        public static string SetSKeyClient(string data, string curComp, string curUsb, string hashPin)
        {
            string key = GenSKey(data, curComp, curUsb, hashPin);
            string sKey = Cryptography.Cryptography.EncryptAes(data, key, hashPin);
            return sKey;
        }
    }
}
