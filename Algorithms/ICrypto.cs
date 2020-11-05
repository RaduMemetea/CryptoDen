using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface ICrypto
    {
        string Encrypt(String message);
        string Decrypt(String message);

    }
}
