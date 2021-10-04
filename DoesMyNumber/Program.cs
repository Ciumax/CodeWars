using System;
using System.Collections.Generic;
namespace DoesMyNumber
{
    public class Kata
    {
        static void Main(string[] args)
        {
            Narcissistic(153);
            Narcissistic(1652);
        }
  public static bool Narcissistic(int value)
  {
     List<int> digits = new List<int>();
     int ans = 0, save = value;
    for (; value != 0; value /= 10)
     {
             digits.Add(value % 10);
     }
    for( int i = 0; i < digits.Count; i++)
    {
        ans += FastPow(digits[i],digits.Count);
    }
    Console.WriteLine(ans + "  " + save);
    if( save == ans){
    return true;
    }else 
    return false;
  }

 public static int FastPow(int x, int pow)
    {
        Console.WriteLine(x + "  " + pow);
        return (int)Math.Pow(x, pow);
    }
    }
}
