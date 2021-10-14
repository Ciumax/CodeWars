using System;
using System.Collections.Generic;
namespace MovingZeros
{
    public class Kata
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] { 1, 1, 3, 1, 5, 2, 1, 5, 0, 3, 3, 5, 0, 0, 5, 1, 0, 3, 5, 4, 3, 5, 5, 3, 4, 3, 3, 3, 3, 0, 0, 1, 0, 5, 3, 2, 1, 3, 2, 0, 2, 1, 2, 2, 1, 4, 4, 3, 2, 1, 3, 4, 2, 0, 1, 1, 1, 0, 2, 2, 4, 3, 1, 0, 2, 1, 5, 1, 3, 3, 5, 2, 0, 5, 1, 1, 2, 3 });
        }

        public static int[] MoveZeroes(int[] arr)
        {
            var arr2 = new List<int>(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr2.Remove(0);
                    arr2.Add(0);
                }
            }
            arr = arr2.ToArray();
            return arr;
        }
    }
}

