using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherConsoleApp
{
    interface ICaesarCipher
    {
        public string EncodeTheMessage(string message, int key);

        public string DecodeTheMessage(string message, int key);
    }
}
