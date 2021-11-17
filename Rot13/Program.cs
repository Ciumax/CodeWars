using System;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Rot13("Test");
        }

        public static string Rot13(string message)
        {
            String answer = "";
            char temp = ' ';
            int value = 13;
            int max = 26;
            for (int i = 0; i < message.Length; i++)
            {
                temp = message[i];
                if (temp >= 97 && temp <= 122)
                {
                    temp += (char) value;
                    if (temp > 122) temp -= (char) max;
                    answer += temp;
                }
                else if (temp >= 65 && temp <= 90)
                {
                    temp += (char) value;
                    if (temp > 90) temp -= (char) max;
                    answer += temp;
                }
                else
                {
                    answer += temp;
                }
            }
            return answer;
        }
    }
}
