using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            //implementing rotate function
            string output = "";
            for (int i = 0; i < text.Length; i++)
            {
                int AsciiValue = (int)text[i];
                if (AsciiValue >= 65 && AsciiValue <= 90)
                {
                    output += (char)((AsciiValue + shiftKey - 65) % 26 + 65);
                }
                else if (AsciiValue >= 97 && AsciiValue <= 122)
                {
                    output += (char)((AsciiValue + shiftKey - 97) % 26 + 97);
                }
                else output += text[i];
            }
            return output;
        }
    }
}
