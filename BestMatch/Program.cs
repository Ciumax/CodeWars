using System;

namespace BestMatch
{
    public class Kata
    {
        static void Main(string[] args)
        {
            int[] g1 = new int[] { 13, 13, 18, 9, 12, 9 };
            int[] g2 = new int[] { 9, 6, 9, 0, 2, 5};
            BestMatch(g1, g2);
        }


        public static int BestMatch(int[] goals1, int[] goals2)
        {
        int[] results = new int[goals1.Length];
            int smallest = 9999999;
            for (int i = 0; i < goals1.Length; i++)
            {
                results[i] = goals1[i] - goals2[i];
                if (results[i] < smallest)
                {
                    smallest = results[i];
                }
            }
            int last = 0;
            int bigger = -1;
            for (int i = 0; i < goals2.Length; i++)
            {
                if (smallest == results[i] && goals2[i] > bigger)
                {
                    bigger = goals2[i];
                    last = i;
                }
            }
            return last;
        }
    }
}

