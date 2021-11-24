using System;

namespace NotVerSecure
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool Alphanumeric(string str)
        {
            if (String.IsNullOrEmpty(str)) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i]) == false) return false;
            }
            return true;
        }
    }
}
