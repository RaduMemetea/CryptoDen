using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Hash
{
    class Md5
    {
        public static String Hash(String input)
        {
            String output = "#";

            using (MD5 md5 = MD5.Create() )
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                    sb.Append(b.ToString("X2"));

                output = sb.ToString();
            }


            return output;
        }
    }
}
