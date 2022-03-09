using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherConsoleApp
{
    public class CaesarCipher : ICaesarCipher
    {
        public string DecodeTheMessage(string message, int key)
        {
            return string.Empty;
        }

        public string EncodeTheMessage(string message, int key)
        {

            
            string newMessage = string.Empty;

            foreach (char character in message)
            {
                if (char.IsLetter(character))
                {
                    newMessage += (char)(character + key); //casting from int to char
                }
                else
                {
                    newMessage += character;
                }
       
            }
            return newMessage;
        }
    }
}
