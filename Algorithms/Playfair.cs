using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Playfair
    {
        private string Key;

        private List<char> Alphabet = new List<char>();
        private char[,] Matrix = new char[5, 5];

        public Playfair(string key = "")
        {
            if (key != null)
                Key = key.ToLowerInvariant();
            else
                Key = "";
            ConstructAlphabetAndMatrix();

        }

        public string GenerateRandomKey()
        {
            string key = "";
            Random r = new Random();

            for (int i = 0; i < 10; i++)
                key += (char)r.Next((int)'a', (int)'z');

            Key = key;
            ConstructAlphabetAndMatrix();

            return Key;
        }


        internal string GetMatrix()
        {
            string matrix = "";
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    matrix += String.Format("{0} ", Matrix[i, j]);

                matrix += "\r\n";
            }
            return matrix;
        }

        private void ConstructAlphabetAndMatrix()
        {
            Alphabet = new List<char>();
            foreach (var item in Key)// add key unique letters to the list
            {
                if (!IsLetter(item)) continue;
                if (item == 'j') continue;//remove j from the alphabet
                if (!Alphabet.Contains(item))
                    Alphabet.Add(item);
            }


            for (char c = 'a'; c <= 'z'; c++)//add the rest of the letters
            {
                if (c == 'j') continue;//remove j from the alphabet
                if (!Alphabet.Contains(c))
                    Alphabet.Add(c);//if unique add to list
            }

            int k = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = Alphabet[k++];   //build the matrix with the letters

        }

        public void PrintMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
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

            message = message.ToLowerInvariant();   // make all the text lowercase 

            int letterNo = 0;
            foreach (var item in message)
                if (IsLetter(item))
                    letterNo++;


            if (letterNo % 2 == 1) message += "z";  // Make shure we have even number of letter



            for (int i = 0; i < message.Length; i++)
            {

                Tuple<int, int> cord1, cord2;   // coordonates of the letters
                String pre = "";                // used to store the non-letters before first letter
                String post = "";               // used to store the non-letters after first letter

                if (i == message.Length - 1 && !IsLetter(message[i])) // If message ends with a non-letter just add it and continue
                {
                    encryptedText += message[i];
                    continue;
                }

                while (!IsLetter(message[i]))   // guarantee that i points to a letter and store the non-letters in the pre
                {
                    pre += message[i];
                    i++;
                    if (i >= message.Length) break;
                }
                if (i >= message.Length)
                {
                    encryptedText += pre;
                    break;
                }
                if (message[i] != 'j')
                    cord1 = Matrix.CoordinatesOf(message[i]);   // find coordonates for the first letter in the group 
                else
                    cord1 = Matrix.CoordinatesOf('i');

                i++;                                        // move the index to the next wanted letter
                if (i >= message.Length) break;

                while (!IsLetter(message[i]))               // guarantee that i points to a letter and store the non-letters in the post
                {
                    post += message[i];
                    i++;
                    if (i >= message.Length) break;

                }
                if (i >= message.Length)
                {
                    encryptedText += post;
                    break;
                }
                if (message[i] != 'j')
                    cord2 = Matrix.CoordinatesOf(message[i]);   // find coordonates for the second letter in the group 
                else
                    cord2 = Matrix.CoordinatesOf('i');



                if (cord1.Item2 == cord2.Item2)// check if same column
                {
                    encryptedText = String.Format("{0}{1}{2}{3}{4}",
                        encryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[(cord1.Item1 + 1) % Matrix.GetLength(0), cord1.Item2],   // first letter from next row
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                        Matrix[(cord2.Item1 + 1) % Matrix.GetLength(0), cord2.Item2]    // second letter form the folowing row
                        );
                    continue;
                }

                if (cord1.Item1 == cord2.Item1)// check if same row
                {
                    encryptedText = String.Format("{0}{1}{2}{3}{4}",
                        encryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[cord1.Item1, (cord1.Item2 + 1) % Matrix.GetLength(1)],   // first letter from next column
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                        Matrix[cord2.Item1, (cord2.Item2 + 1) % Matrix.GetLength(1)]    // second letter from the folowing column
                    );
                    continue;
                }

                //otherwise make the square nad chose the oposite corner letters
                encryptedText = String.Format("{0}{1}{2}{3}{4}",
                        encryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[cord1.Item1, cord2.Item2],                               // first letter from mirrored corner
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                         Matrix[cord2.Item1, cord1.Item2]                               // second letter from mirrored corner
                    );

            }

            return encryptedText;
        }

        public string Decrypt(string message)
        {
            string decryptedText = "";

            int letterNo = 0;
            foreach (var item in message)
                if (IsLetter(item))
                    letterNo++;

            if (letterNo % 2 == 1)   //if not even trow error
                throw new System.InvalidProgramException("The decryption text was not even!");


            for (int i = 0; i < message.Length; i++)
            {
                Tuple<int, int> cord1, cord2;   // coordonates of the letters
                String pre = "";                // used to store the non-letters before first letter
                String post = "";               // used to store the non-letters after first letter

                if (i == message.Length - 1 && !IsLetter(message[i])) // If message ends with a non-letter just add it and continue
                {
                    decryptedText += message[i];
                    continue;
                }

                while (!IsLetter(message[i]))   // guarantee that i points to a letter and store the non-letters in the pre
                {
                    pre += message[i];
                    i++;
                    if (i >= message.Length) break;

                }
                if (i >= message.Length)
                {
                    decryptedText += pre;
                    break;
                }

                if (message[i] != 'j')
                    cord1 = Matrix.CoordinatesOf(message[i]);   // find coordonates for the first letter in the group 
                else
                    cord1 = Matrix.CoordinatesOf('i');

                i++;                                        // move the index to the next wanted letter
                if (i >= message.Length) break;

                while (!IsLetter(message[i]))               // guarantee that i points to a letter and store the non-letters in the post
                {
                    post += message[i];
                    i++;
                    if (i >= message.Length) break;

                }

                if (message[i] != 'j')
                    cord2 = Matrix.CoordinatesOf(message[i]);   // find coordonates for the second letter in the group 
                else
                    cord2 = Matrix.CoordinatesOf('i');

                if (cord1.Item2 == cord2.Item2)// check if same column
                {
                    decryptedText = String.Format("{0}{1}{2}{3}{4}",
                        decryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[(cord1.Item1 + Matrix.GetLength(0) - 1) % Matrix.GetLength(0), cord1.Item2],   // first letter from previous row
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                        Matrix[(cord2.Item1 + Matrix.GetLength(0) - 1) % Matrix.GetLength(0), cord2.Item2]    // second letter form the previous previous row
                        );
                    continue;
                }

                if (cord1.Item1 == cord2.Item1)// check if same row
                {
                    decryptedText = String.Format("{0}{1}{2}{3}{4}",
                        decryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[cord1.Item1, (cord1.Item2 + Matrix.GetLength(1) - 1) % Matrix.GetLength(1)],   // first letter from previous column
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                        Matrix[cord2.Item1, (cord2.Item2 + Matrix.GetLength(1) - 1) % Matrix.GetLength(1)]    // second letter from the previous previous column
                    );
                    continue;
                }

                //otherwise make the square nad chose the oposite corner letters
                decryptedText = String.Format("{0}{1}{2}{3}{4}",
                        decryptedText,                                                  // existing text
                        pre,                                                            // if the first index was not a letter, all the non-letters until the first
                        Matrix[cord1.Item1, cord2.Item2],                               // first letter from mirrored corner
                        post,                                                           // if the second index was not a letter, all the non-letters until the second
                         Matrix[cord2.Item1, cord1.Item2]                               // second letter from mirrored corner
                    );


            }
            return decryptedText;
        }

    }

    public static class ExtensionMethods
    {
        public static Tuple<int, int> CoordinatesOf<T>(this T[,] matrix, T value)// find the coordonates of a letter in a matrix
        {
            int w = matrix.GetLength(0); // width
            int h = matrix.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }

    }


}
