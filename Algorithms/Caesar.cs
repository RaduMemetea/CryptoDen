using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    class Caesar:Crypto
    {
        private string Key;
        private List<char> Alphabet;
        private int Shift;

        public Caesar(int shift, string key)
        {
            Shift = shift;
            Key = key;
            ConstructAlphabet();
        }
        public Caesar(int shift=0)
        {
            string key = "";
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                key += (char)r.Next((int)'a', (int)'z');
            }
            Key = key;
            ConstructAlphabet();

        }
        public string GetKeys()
        {
            return Key;
        }
        public void ModifyKey(string key)
        {
            Key = key.ToLowerInvariant();
            ConstructAlphabet();
        }

        private void ConstructAlphabet()
        {
            Alphabet = new List<char>();

            foreach (var item in Key)// add key unique letters to the list
            {
                if (!IsLetter(item)) continue;
                if (!Alphabet.Contains(item))
                    Alphabet.Add(item);
            }

            for (char c = 'a'; c <= 'z'; c++)//add the rest of the letters
                if (!Alphabet.Contains(c))
                    Alphabet.Add(c);//if unique add to list
        }
        private bool IsLetter(char value)
        {
            if (value >= 'a' && value <= 'z') return true;
            if (value >= 'A' && value <= 'Z') return true;
            return false;
        }

        public string Encrypt(string message)
        {
            string encryptedText = "";

            message = message.ToLowerInvariant();


            foreach (var chr in message)
            {
                if (!IsLetter(chr))
                {
                    encryptedText += chr;
                    continue;
                }

                int encindex = (chr - 'a' + Shift + Alphabet.Count) % Alphabet.Count;

                encryptedText += Alphabet.ElementAt(encindex);

            }
            return encryptedText;

        }



        public string Decrypt(string message)
        {
            string decryptedText = "";

            message = message.ToLowerInvariant();


            foreach (var chr in message)
            {
                if (!IsLetter(chr))
                {
                    decryptedText += chr;
                    continue;
                }

                int decIndex = (Alphabet.IndexOf(chr) - Shift + Alphabet.Count) % Alphabet.Count;

                decryptedText += (char)('a' + decIndex);



            }
            return decryptedText;
        }

        public string GetAlphabet()
        {
            string alphabet = "";
            foreach (var item in Alphabet)
                alphabet += $"{item} ";
            
            return alphabet;
        }
    }
}
