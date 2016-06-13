using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Model
    {
        internal static CAService.CAClient CreateWebServiceInstance(string address)
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
            return new CAService.CAClient(binding, new EndpointAddress("http://"+address+":45000/CA.CA"));
        }

        internal static void SendMessageForJoinCA()
        {
            string[] masData = DecryptServerData();
            string message = masData[0] + " 6 1 " + DateTime.Now;
            message = message + " " + Cryptography.Cryptography.GetHash(message);
            message = message + " " + Cryptography.Cryptography.Sign(message, masData[1]);
            string testMsg = message;
            message = Cryptography.Cryptography.Encrypt(message, masData[2]);
            string data="";
            data = JoinToCA(message, masData[3]);
            var srvData = DecryptServerData();
            data = Cryptography.Cryptography.Decrypt(data, srvData[1]);
            if (!checkData(data, srvData[2]))
                return;
            masData = data.Split(' ');
            ControlFW.SetListRules(masData[2]);
        }
        private static bool checkData(string data, string pubKeyCA)
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

        internal static string[] DecryptServerData()
        {
            string data = File.ReadAllText(@"C:\ProgramData\ServerKey\srv.key");
            return data.Split(' ');
        }

        internal static bool CheckServerData()
        {
            return true;
        }
        

        internal static string JoinToCA(string data, string ipCA)
        {
            var service = CreateWebServiceInstance(ipCA);
            service.Open();
            data = service.JoinServer(data);
            return data;
        }
        internal static string RegistrateToCA(string data, string ipCA)
        {
            var service = CreateWebServiceInstance(ipCA);
            data = service.RegistrateServer(data);
            return data;
        }

    }
}
