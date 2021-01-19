using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Hash
{
    public enum ShaSize
    {
        SHA1 = 1,
        SHA256 = 256,
        SHA384 = 384,
        SHA512 = 512
    }
    class SHA
    {
        public static String Hash(String input, ShaSize size)
        {
            String output = "#";

            switch (size)
            {
                case ShaSize.SHA1:

                    using(SHA1Managed sha = new SHA1Managed())
                    {
                        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                        var sb = new StringBuilder(hash.Length * 2);

                        foreach (byte b in hash)
                            sb.Append(b.ToString("X2"));

                        output = sb.ToString();
                    }

                    break;

                case ShaSize.SHA256:

                    using (SHA256 sha = SHA256.Create())
                    {
                        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                        var sb = new StringBuilder(hash.Length * 2);

                        foreach (byte b in hash)
                            sb.Append(b.ToString("X2"));

                        output = sb.ToString();
                    }

                    break;

                case ShaSize.SHA384:

                    using (SHA384 sha = SHA384.Create())
                    {
                        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                        var sb = new StringBuilder(hash.Length * 2);

                        foreach (byte b in hash)
                            sb.Append(b.ToString("X2"));

                        output = sb.ToString();
                    }

                    break;

                case ShaSize.SHA512:

                    using (SHA512 sha = SHA512.Create())
                    {
                        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                        var sb = new StringBuilder(hash.Length * 2);

                        foreach (byte b in hash)
                            sb.Append(b.ToString("X2"));

                        output = sb.ToString();
                    }

                    break;

            }

            return output;
        }


    }
}
