using System;
using System.Collections.Generic;

public class Kata
{
 public static bool Narcissistic(int value)
        {
            List<int> digits = new List<int>();
            int
                ans = 0,
                save = value;
            for (; value != 0; value /= 10)
            {
                digits.Add(value % 10);
            }
            for (int i = 0; i < digits.Count; i++)
            {
                ans += PowerOF(digits[i], digits.Count);
            }
            return save == ans;
        }

        public static int PowerOF(int x, int pow)
        {
            return (int) Math.Pow(x, pow);
        }
}
}
