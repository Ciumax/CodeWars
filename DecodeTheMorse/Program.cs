using System;

namespace DecodeTheMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static string Decode(string morseCode)
        {
            morseCode = morseCode.Replace("  ", " ");
            String[] letters = morseCode.Split(" ");
            String answer = "";
            foreach (var item in letters)
            {
                answer += MorseCode.Get(item);
                if (String.IsNullOrWhiteSpace(item))
                {
                    answer += " ";
                }
            }
            return answer.Trim();
        }
    }
}
