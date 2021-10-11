using System;
using System.Text.RegularExpressions;

namespace SimpiePigLatin
{
    public class Kata
    {
        static void Main(string[] args)
        {
            PigIt("Pig latin is cool");
        }

        public static string PigIt(string str)
        {
            string ay = "ay";
            string[] Arr = str.Split(" ");
            string result = "";
            Regex rgx = new Regex("[^A-Za-z0-9]");
            foreach (string element in Arr)
            {
                if (!rgx.IsMatch(element))
                {
                    result +=
                        element.Substring(1, element.Length - 1) +
                        element[0] +
                        ay +
                        " ";
                }
                else
                {
                    result += element;
                }
            }
            return result.Trim();
        }
    }
}
