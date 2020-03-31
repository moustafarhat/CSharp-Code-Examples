using System;

namespace CaesarCipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string plainText = "Attack at night with all forces";
            string cipherText = "dwwdfn dw qljkw zlwk doo irufhv";
            char[] cipher;
            Console.WriteLine("Cipher text : ");
            foreach (var item in cipherText)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("Plain text : ");
            //cipher = CaesarCipher.Encrypt(plainText, 3);
            foreach (var item in CaesarCipher.Decrypt(cipherText, 3))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

    internal class CaesarCipher
    {
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }

        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherText.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return plainArray;
        }
    }
}