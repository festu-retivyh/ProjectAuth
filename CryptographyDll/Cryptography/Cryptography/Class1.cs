using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Cryptography
{
    public struct sCertData
    {
        public string login;
        public string fioOwner;
        public DateTime dStart;
        public DateTime dStop;
    }
    public static class Cryptography
    {
        static int lengthKey = 3072;
        /// <summary>
        /// Converts the RSA-encrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted text</returns>
        public static string Encrypt(string text, string publicKeyXml)
        {
            int maxLength = GetMaxDataLength(lengthKey) - 1;
            var data = StringToByteArray(text);
            int masLength = data.Length;
            int start = 0, stop = 0;
            byte[] masForCrypt;
            string returnData = "";
            while (stop < masLength)
            {
                start = stop;
                stop = stop + maxLength;
                masForCrypt = ArrayResize(data, start, stop);
                returnData = returnData + Convert.ToBase64String(EncryptByteArray(masForCrypt, publicKeyXml, lengthKey)) + " ";
            }
            start = stop;
            stop = stop + maxLength;
            masForCrypt = ArrayResize(data, start, stop);
            returnData = returnData + Convert.ToBase64String(EncryptByteArray(masForCrypt, publicKeyXml, lengthKey));

            //var encrypted = EncryptByteArray(Encoding.UTF8.GetBytes(text), publicKeyXml, lengthKey);

            return returnData;
        }
        private static byte[] ArrayResize(byte[] data, int start, int stop)
        {
            byte[] newMas = new byte[stop - start];
            int counter = 0;
            for (int i = start; i < stop; i++)
            {
                if (i >= data.Length)
                    break;
                newMas[counter] = data[i];
                counter = counter + 1;
            }
            return newMas;
        }

        /// <summary>
        /// Gets and validates the RSA-encrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted byte array</returns>
        private static byte[] EncryptByteArray(byte[] data, string publicKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            int maxLength = GetMaxDataLength(keySize);

            if (data.Length > maxLength)
            {
                throw new ArgumentException(string.Format("Maximum data length is {0}", maxLength), "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (String.IsNullOrEmpty(publicKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, false);
            }
        }

        /// <summary>
        /// Converts the RSA-decrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted text</returns>
        public static string Decrypt(string text, string publicAndPrivateKeyXml)
        {
            var mas = text.Split(' ');
            string returnText = "";
            foreach (var m in mas)
            {
                returnText = returnText + ByteArrayToString(DecryptByteArray(Convert.FromBase64String(m), publicAndPrivateKeyXml, lengthKey));
            }
            return returnText;
        }

        /// <summary>
        /// Gets and validates the RSA-decrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted byte array</returns>
        private static byte[] DecryptByteArray(byte[] data, string publicAndPrivateKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (string.IsNullOrEmpty(publicAndPrivateKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, false);
            }
        }

        /// <summary>
        /// Gets the maximum data length for a given key
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The maximum allowable data length</returns>
        private static int GetMaxDataLength(int keySize)
        {
            return ((keySize - 384) / 8) + 37;
        }

        /// <summary>
        /// Checks if the given key size if valid
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>True if valid; false otherwise</returns>
        private static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                   keySize <= 16384 &&
                   keySize % 8 == 0;
        }


        public static string GenerateKey(int length)
        {
            string key = "";
            string symbols = @"1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁйцукенгшщзхъфывапролджэячсмитьбюё.,?/\|=+_-*!@#$%^&()";
            int count = symbols.Length;
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                key = key + symbols[rand.Next(count)];
            }
            return key;
        }
        public static string GeneratePrivateKey()
        {
            //TODO: Предусмотреть проверку выбранного метода шифрования
            RSACryptoServiceProvider cspRSA = new RSACryptoServiceProvider(lengthKey);
            return KeyToString(cspRSA.ExportParameters(true));
        }
        public static string GetHash(string data)
        {
            SHA256 CSP = new SHA256Managed();
            data = ByteArrayToString(CSP.ComputeHash(StringToByteArray(data)));
            return data;
        }
        public static string GetPublicKey(string parametrs)
        {
            //TODO: Предусмотреть проверку выбранного метода шифрования
            RSAParameters cspParams = KeyFromString(parametrs);
            RSACryptoServiceProvider cspRSA = new RSACryptoServiceProvider(lengthKey);
            cspRSA.ImportParameters(cspParams);
            return KeyToString(cspRSA.ExportParameters(false));
        }

        public static string KeyToString(RSAParameters key)
        {
            //we need some buffer
            var sw = new StringWriter();
            //we need a serializer
            var xs = new XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, key);
            //get the string from the stream
            return sw.ToString();
        }
        public static RSAParameters KeyFromString(string key)
        {
            //get a stream from the string
            var sr = new StringReader(key);
            //we need a deserializer
            var xs = new XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            return (RSAParameters)xs.Deserialize(sr);
        }

        public static string Sign(string data, string key)
        {
            //TODO: code for sign data 
            //return only sign (without data)
            
            RSACryptoServiceProvider CSP = new RSACryptoServiceProvider(lengthKey);
            CSP.ImportParameters(KeyFromString(key));
            data = Convert.ToBase64String(CSP.SignData(StringToByteArray(data), new SHA384CryptoServiceProvider()));
            return data;
        }
        public static bool CheckSign(string data, string sign, string key)
        {
            //TODO: code for checking sign for data
            RSACryptoServiceProvider CSP = new RSACryptoServiceProvider(lengthKey);
            CSP.ImportParameters(KeyFromString(key));
            var _sign = Convert.FromBase64String(sign.Replace("\0",""));
            bool rezult = CSP.VerifyData(StringToByteArray(data), new SHA384CryptoServiceProvider(), _sign);
                
            return rezult;
        }
        public static Certificate GetCertificate(sCertData data, string privateKey)
        {
            Certificate cert = new Certificate(data, privateKey);
            return cert;
        }
        public static string CertificateToString(Certificate cert)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Certificate));
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, cert);
            return stringWriter.ToString();
        }
        public static Certificate CertificateFromString(string cert)
        {
            var xmlSerializer = new XmlSerializer(typeof(Certificate));
            var stringReader = new StringReader(cert);
            return (Certificate)xmlSerializer.Deserialize(stringReader);
        }

        public static string EncryptAes(string input, string key, string pin)
        {
            byte[] iv = StringToByteArray(pin);
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input), iv, key));
        }
        private static byte[] Encrypt(byte[] input, byte[] iv, string pass)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(pass, iv);
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }
        public static string DecryptAes(string input, string key, string pin)
        {
            byte[] iv = StringToByteArray(pin);
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input), iv, key));
        }
        private static byte[] Decrypt(byte[] input, byte[] iv, string pass)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(pass, iv);
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return Encoding.Unicode.GetString(ba);
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Encoding.Unicode.GetBytes(hex);
        }

        

        
    }

    [Serializable]
    public class Certificate
    {
        public DateTime dateStart, dateStop, dateCreating;
        public string ownerName, login, caName, caAddress, nameAsimCript, nameHash, verCert, publicKey, hash, sign;
        byte type;
        public Certificate(string login, string fioOwner, DateTime dStart, DateTime dStop, string privateKey)
        {
            dateCreating = DateTime.Now;
            dateStart = dStart;
            dateStop = dStop;
            ownerName = fioOwner;
            this.login = login;
            caName = "center autentification server";
            caAddress = "192.168.0.100";
            nameAsimCript = "RSA";
            nameHash = "SHA512";
            verCert = "0.0.1";
            publicKey = Cryptography.GetPublicKey(privateKey);
        }
        public Certificate(sCertData data, string privateKey, byte type = 1)
        {
            dateCreating = DateTime.Now;
            dateStart = data.dStart;
            dateStop = data.dStop;
            ownerName = data.fioOwner;
            login = data.login;
            caName = "center autentification server";
            caAddress = "192.168.0.100";
            nameAsimCript = "RSA";
            nameHash = "SHA512";
            verCert = "0.0.1";
            this.type = type;
            publicKey = Cryptography.GetPublicKey(privateKey);
        }
        public Certificate() { }
        public void CalculateCertSign(string privateKeyCA)
        {
            if (publicKey == "" || publicKey == null)
                return;
            sign = Cryptography.Sign(publicKey, privateKeyCA);
        }
    }
}
