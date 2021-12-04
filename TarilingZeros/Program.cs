using System;

namespace TarilingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int TrailingZeros(int n)
        {
            int answer = 0;
            while (n >= 5)
            {
                answer += (n / 5);
                n = n / 5;
            }
            return answer;
        }
    }
}
