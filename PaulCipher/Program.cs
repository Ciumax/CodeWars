using System;

namespace PaulCipher
{
    public class PaulCipher
    {
        static void Main(string[] args)
        {
            Encode("The quick brown fox jumps over the lazy dog.");
            Decode("HM1QA");
        }

        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input) == true)
            {
                return "";
            }
            input = input.ToUpper();
            int diffrence = 0;
            int current = 0;
            int temp = 0;
            char currentLetter;
            String encoded = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > 64 && (int)input[i] < 91)
                {
                    current = (int)input[i];
                    current = current + diffrence;
                    if (current > 90)
                    {
                        temp = current - 90;
                        current = 64 + temp;
                        if (current > 90)
                        {
                            temp = current - 90;
                            current = 64 + temp;
                        }
                    }
                    if (current < 65)
                    {
                        temp = 64 - current;
                        current = 90 - temp;
                    }
                    currentLetter = (char)current;
                    encoded += currentLetter.ToString();
                    diffrence = current - 64 - diffrence;
                }
                else
                {
                    encoded += input[i];
                }
            }
            return encoded;
        }
        public static string Decode(string input)
        {
            if (string.IsNullOrEmpty(input) == true)
            {
                return "";
            }
            input = input.ToUpper();
            int diffrence = 0;
            int current = 0;
            int temp = 0;
            char currentLetter;
            String decoded = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > 64 && (int)input[i] < 91)
                {
                    current = (int)input[i];
                    current = current - diffrence;
                    if (current < 65)
                    {
                        temp = 64 - current;
                        current = 90 - temp;
                    }
                    if (current > 90)
                    {
                        temp = current - 90;
                        current = 64 + temp;
                    }
                    currentLetter = (char)current;
                    decoded += currentLetter.ToString();
                    diffrence = current - 64;//- diffrence;
                }
                else
                {
                    decoded += input[i];
                }
            }
            return decoded;
        }
    }
}


