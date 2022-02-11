using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK_47_Creator.Cryption
{
    interface ICrypt
    {
        string Encrypt(string Val, string Key);
        string Decrypt(string Val, string Key);

    }
}
