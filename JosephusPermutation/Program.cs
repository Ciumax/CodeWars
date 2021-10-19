using System;
using System.Collections.Generic;
namespace JosephusPermutation
{

    public class Josephus
    {
        static void Main(string[] args)
        {
            List<object> test = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
            List<object> test2 = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<object> test3 = new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" };
            JosephusPermutation(test, 3);
            // JosephusPermutation(test2, 1);
            //JosephusPermutation(test2, 2);
        }

        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> result = new List<object> { };
            int check = -1;
            int guard = items.Count;
            for (int i = 0; i < guard; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    check++;
                    if (check > items.Count - 1) check = 0;
                }
                result.Add(items[check]);
                items.RemoveAt(check);
                check--;
            }
            return result;
        }
    }
}
