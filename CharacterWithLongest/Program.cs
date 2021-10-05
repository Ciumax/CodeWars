using System;

namespace Solution
{
    public static class Kata
    {
        static void Main(string[] args)
        {
            LongestRepetition("aaaabb");
            LongestRepetition("abbbbb");
            LongestRepetition("cbdeuuu900");
            LongestRepetition("");
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new Tuple<char?, int>(null, 0);
            }
            char check = input[0];
            int count = 0;
            int highestCount = 0;
            char highestChar = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (check == input[i])
                {
                    count++;
                }
                else
                {
                    if (count > highestCount)
                    {
                        highestCount = count;
                        highestChar = check;
                    }
                    count = 1;
                    check = input[i];
                }
            }
            if (count > highestCount)
            {
                highestCount = count;
                highestChar = check;
            }
            return new Tuple<char?, int>(highestChar, highestCount);
        }
    }
}

