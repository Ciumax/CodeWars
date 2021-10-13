using System;

namespace FindTheOddInt
{
    class Kata
    {
        static void Main(string[] args)
        {
            find_it(new []
            { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
        }

        public static int find_it(int[] seq)
        {
            int counter = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        counter++;
                    }
                }
                if (counter % 2 != 0)
                {
                    return seq[i];
                }
                counter = 0;
            }
            return -1;
        }
    }
}
