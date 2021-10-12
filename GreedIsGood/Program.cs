using System;

namespace GreedIsGood
{
    public static class Kata
    {
        static void Main(string[] args)
        {
            Score(new int[] { 1, 1, 1, 5, 1 });
        }

        public static int Score(int[] dice)
        {
            int[] counter = new int[6];
            int score = 0;
            foreach (int roll in dice)
            {
                switch (roll)
                {
                    case 1:
                        counter[0]++;
                        break;
                    case 2:
                        counter[1]++;
                        break;
                    case 3:
                        counter[2]++;
                        break;
                    case 4:
                        counter[3]++;
                        break;
                    case 5:
                        counter[4]++;
                        break;
                    case 6:
                        counter[5]++;
                        break;
                }
            }
            for (int i = 1; i < counter.Length; i++)
            {
                if (counter[0] > 2)
                {
                    score += 1000;
                    counter[0] -= 3;
                }
                if (counter[i] > 2)
                {
                    score += 100 * (i + 1);
                    counter[i] -= 3;
                }
            }
            if (counter[0] > 0)
            {
                score += 100 * counter[0];
            }
            if (counter[4] > 0)
            {
                score += 50 * counter[4];
            }

            return score;
        }
    }
}
