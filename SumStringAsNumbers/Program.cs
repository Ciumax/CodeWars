using System;
using System.Numerics;
namespace SumStringAsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sumStrings("123","456");
        }

        public static string sumStrings(string a, string b)
        { 
            if(String.IsNullOrEmpty(a)) a = "0";
            if(String.IsNullOrEmpty(b)) b = "0";
            var bigNumber = BigInteger.Parse(a) + BigInteger.Parse(b);
            string answer = number + "";
            return answer;
        }
    }
}
