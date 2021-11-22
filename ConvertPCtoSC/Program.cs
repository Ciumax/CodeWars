using System;

namespace ConvertPCtoSC
{
    class Program
    {
        static void Main(string[] args)
        {
            ToUnderscore("TestController");      
        }
        public static string ToUnderscore(int str)
        {
            string answer = "";
            return answer = str.ToString();
        }
        public static string ToUnderscore(string str)
        {
            string answer = "";
            for(int i = 0; i < str.Length; i++)
            {
                if(Char.IsUpper(str[i]) == true && i != 0)
                {
                    answer += "_" + str[i];
                }
                else
                {
                    answer += str[i];
                }
            }
            return answer.ToLower();
        }
    }
}
