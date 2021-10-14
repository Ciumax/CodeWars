using System;
using System.Collections.Generic;

namespace DoubleCola
{
    public class Line
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 52;
            WhoIsNext(names, n);
        }


        public static string WhoIsNext(string[] names, long n)
        {
            int counter = 5;
            int tester = 5;
            int check = 0;
            int[] ranges = new int[6];
            while (n > tester)
            {
                counter = counter * 2;
                check = tester;
                tester += counter;
            }
            for (int i = 0; i <= 5; i++)
            {
                ranges[i] = counter / 5;
                ranges[i] = ranges[i] * i;
            }
            n = n - check;
            if (n > 0 && n <= ranges[1])
            {
                return "Sheldon";
            }
            if (n > ranges[1] && n <= ranges[2])
            {
                return "Leonard";
            }
            if (n > ranges[2] && n <= ranges[3])
            {
                return "Penny";
            }
            if (n > ranges[3] && n <= ranges[4])
            {
                return "Rajesh";
            }
            if (n > ranges[4] && n <= ranges[5])
            {
                return "Howard";
            }
            return null;
        }
    }
}
