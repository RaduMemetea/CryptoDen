using System;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms
{
    class RSA
    {

        public enum KeySize
        {
            Key512 = 512,
            Key1024 = 1024,
            Key2048 = 2048,
            Key4096 = 4096
        }

        public class KeyPair
        {
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }
        }


        public KeyPair Keys { get; private set; }

        public RSA(string PublicKey, string PrivateKey)
        {
            Keys = new KeyPair();
            Keys.PublicKey = PublicKey;
            Keys.PrivateKey = PrivateKey;

        }

        public RSA(KeySize size = KeySize.Key2048)
        {
            GenerateKeys(size);
        }

        public void GenerateKeys(KeySize size)
        {
            Keys = new KeyPair();

            using (var provider = new RSACryptoServiceProvider((int)size))
            {
                var publicKey = provider.ToXmlString(false);
                var privateKey = provider.ToXmlString(true);
                Keys.PublicKey = Convert.ToBase64String(Encoding.UTF8.GetBytes((int)size + "#" + publicKey));
                Keys.PrivateKey = Convert.ToBase64String(Encoding.UTF8.GetBytes((int)size + "#" + privateKey));
            }

        }

        public string Encrypt(string text)
        {
            int keySize = 0;
            string publicKeyXML = "";
            GetKeyFromString(Keys.PublicKey, out keySize, out publicKeyXML);

            var encrypted = Encrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXML);

            return Convert.ToBase64String(encrypted);
        }

        private static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
        {
            if (data.Length > (((keySize - 384) / 8) + 7)) throw new ArgumentException($"Data lenght exceded, max is {((keySize - 384) / 8) + 7} and current is {data.Length}");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicKeyXml)) throw new ArgumentException("Key is null or empty", "publicKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, true);
            }
        }


        public string Decrypt(string text)
        {
            int keySize = 0;
            string PrivateKeyXml = "";

            GetKeyFromString(Keys.PrivateKey, out keySize, out PrivateKeyXml);

            var decrypted = Decrypt(Convert.FromBase64String(text), keySize, PrivateKeyXml);

            return Encoding.UTF8.GetString(decrypted);
        }

        private byte[] Decrypt(byte[] data, int keySize, string PrivateKeyXml)
        {
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(PrivateKeyXml)) throw new ArgumentException("Key is null or empty", "PrivateKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(PrivateKeyXml);
                return provider.Decrypt(data, true);
            }
        }



        private static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 && keySize <= 16384 && keySize % 8 == 0;
        }
        private void GetKeyFromString(string rawKey, out int keySize, out string xmlKey)
        {
            keySize = 0;
            xmlKey = "";

            byte[] keyBytes = Convert.FromBase64String(rawKey);
            var stringKey = Encoding.UTF8.GetString(keyBytes);

            if (stringKey.Contains("#"))
            {
                var splittedValues = stringKey.Split(new char[] { '#' }, 2);

                try
                {
                    keySize = int.Parse(splittedValues[0]);
                    xmlKey = splittedValues[1];
                }
                catch (Exception e) { throw e; };


            }

        }

    }

}
