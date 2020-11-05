using System;
using System.Numerics;

namespace Algorithms
{
    public class RSA: ICrypto
    {
        private Tuple<long, long> PublicKey;
        private Tuple<long, long> PrivateKey;
        private readonly long phi;

        public RSA(long number1, long number2)
        {
            phi = GetPhi(number1, number2);
            GeneratePublicKey(number1, number2);
            GeneratePrivateKey(number1, number2);
        }

        public RSA()
        {
            long number1 = RandomPrime(1000, 100000),
                number2 = RandomPrime(10000, 200000);


            phi = GetPhi(number1, number2);
            GeneratePublicKey(number1, number2);
            GeneratePrivateKey(number1, number2);
        }
        public RSA(Tuple<long, long> publicKey, Tuple<long, long> privateKey)
        {
            
            PublicKey = publicKey;
            PrivateKey = privateKey;
           
        }

        private long RandomPrime(int min, int max)
        {
            while (true)
            {
                int nr = new Random().Next(min, max);
                if (nr % 2 == 0) continue;

                if (IsPrime(nr, 10)) return nr;
            }

        }
        private bool IsPrime(int n, long k)
        {
            if ((n < 2) || (n % 2 == 0)) return (n == 2);

            int s = n - 1;
            while (s % 2 == 0) s >>= 1;

            Random r = new Random();
            for (int i = 0; i < k; i++)
            {
                int a = r.Next(n - 1) + 1;
                int temp = s;
                long mod = 1;
                for (int j = 0; j < temp; ++j) mod = (mod * a) % n;
                while (temp != n - 1 && mod != 1 && mod != n - 1)
                {
                    mod = (mod * mod) % n;
                    temp *= 2;
                }

                if (mod != n - 1 && temp % 2 == 0) return false;
            }
            return true;

        }

        public Tuple<Tuple<long, long>, Tuple<long, long>> GetKeys()
        {
            return Tuple.Create(PublicKey, PrivateKey);
        }

        // Greatest Common Divisor
        private long Gcd(long number, long divizor)
        {
            long a = number, b = divizor;
            long c;

            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        private long GetPhi(long p, long q) { return (p - 1) * (q - 1); }

        private void GeneratePublicKey(long number1, long number2)
        {
            long pubKeyExp;
            pubKeyExp = 2;
            if (pubKeyExp < 2) pubKeyExp = 2;

            while (true)
                if (Gcd(pubKeyExp, phi) == 1)
                    break;
                else
                    pubKeyExp++;

            PublicKey = new Tuple<long, long>(number1 * number2, pubKeyExp);
        }
        private void GeneratePrivateKey(long number1, long number2)
        {
            long privKeyExp;
            privKeyExp = PublicKey.Item2;
            if (privKeyExp < 2) privKeyExp = 2;
            while (!(((privKeyExp * PublicKey.Item2) % phi) == 1))
                privKeyExp++;

            PrivateKey = new Tuple<long, long>(number1 * number2, privKeyExp);

        }

        public string Encrypt(String message)
        {
            if (message is null || message.Length < 1)
                return null;

            string encryptedText = "";

            foreach (var character in message)
            {
                encryptedText = String.Format("{0} {1}",
                    encryptedText,
                    BigInteger.ModPow((long)character, PublicKey.Item2, PublicKey.Item1)
                    );
            }

            return encryptedText;
        }
        public string Decrypt(String message)
        {
            if (message is null || message.Length < 1)
                return null;

            string decryptedText = "";

            foreach (var character in message.Split(' '))
            {
                if (character == "") continue;
                decryptedText = String.Format("{0}{1}",
                    decryptedText,
                    (char)BigInteger.ModPow(long.Parse(character), PrivateKey.Item2, PrivateKey.Item1)
                    );
            }

            return decryptedText;
        }
    }


}
