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
            Keys= new KeyPair();
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
                Keys.PublicKey = Convert.ToBase64String(Encoding.UTF8.GetBytes((int)size + "!" + publicKey));
                Keys.PrivateKey = Convert.ToBase64String(Encoding.UTF8.GetBytes((int)size + "!" + privateKey));
            }

        }

        public string Encrypt(string text)
        {
            int keySize = 0;
            string publicKeyXML = "";

            


            return;
        }




    }

}
