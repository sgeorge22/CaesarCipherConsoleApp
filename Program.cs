using System;

namespace CaesarCipherConsoleApp
{
    enum CodingMethod { ENCODE = 1, DECODE = 2 };
    internal class Program
    {
        static void Main()
        {
            var caesarCipher = new CaesarCipher();

            //TODO: Add CaesarCipher Object
            while (true)
            {

                var methodOfCoding = GetMethodOfCodingFromCommandLine();
                var message = GetMessageFromCommandLine();
                var key = GetKeyFromCommandLine();

                if (methodOfCoding == (int)CodingMethod.ENCODE)
                {
                    //TODO: Generate encoded message
                    var encodedMessage = caesarCipher.EncodeTheMessage(message, key);
                    Console.WriteLine($"\nThe encoded message with a key of {key} is: {encodedMessage}\n");
                }
                else if (methodOfCoding == (int)CodingMethod.DECODE)
                {
                    //TODO: Generate decoded message
                    var decodedMessage = "";
                    Console.WriteLine($"\nThe decoded message with a key of {key} is: {decodedMessage}\n");
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }

        public static int GetMethodOfCodingFromCommandLine()
        {
            Console.WriteLine("To Encode a message enter 1.\nTo Decode a message enter 2.");
            var methodOfCoding = Console.ReadLine();
            if (methodOfCoding == null)
            {
                Environment.Exit(1);
            }
            var methodOfCodingAsInt = Convert.ToInt32(methodOfCoding);
            if (methodOfCodingAsInt != (int)CodingMethod.ENCODE && methodOfCodingAsInt != (int)CodingMethod.DECODE)
            {
                Environment.Exit(1);
            }
            return methodOfCodingAsInt;
        }

        public static string GetMessageFromCommandLine()
        {
            Console.WriteLine("\nPlease enter a message:");
            var message = Console.ReadLine();
            if (message == null)
            {
                Environment.Exit(1);
            }
            return message;
        }

        public static int GetKeyFromCommandLine()
        {
            Console.WriteLine("\nPlease enter a key:");
            var key = Console.ReadLine();
            if (key == null)
            {
                Environment.Exit(1);
            }
            return Convert.ToInt32(key);
        }
    }
}
