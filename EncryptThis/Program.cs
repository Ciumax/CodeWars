using System;
using System.Text;

namespace EncryptThis
{
    public class Kata
    {
        static void Main(string[] args)
        {
            EncryptThis("The less he spoke the more he heard");
        }

        public static string EncryptThis(string input)
        {
            string[] StringTab = input.Split(" ");
            string ans = "";
            for (int i = 0; i < StringTab.Length; i++)
            {
                byte[] temp = Encoding.ASCII.GetBytes(StringTab[i]);
                StringBuilder StrBud =
                    new StringBuilder(StringTab[i], StringTab.Length);
                if (StringTab[i].Length == 1)
                {
                    StrBud.Replace(StringTab[i], Convert.ToString(temp[0]));
                }
                else if (StringTab[i].Length == 2)
                {
                    StrBud.Clear();
                    StrBud.Insert(0, StringTab[i][StringTab[i].Length - 1]);
                    StrBud.Insert(0, Convert.ToString(temp[0]));
                }
                else if (StringTab[i].Length > 2)
                {
                    StrBud.Clear();
                    StrBud.Append(Convert.ToString(temp[0]));
                    StrBud.Append(StringTab[i][StringTab[i].Length - 1]);
                    StrBud.Append(StringTab[i].Substring(2, StringTab[i].Length - 3));
                    StrBud.Append(StringTab[i][1]);
                }
                    ans += StrBud + " ";
            }
            return ans.Trim();
        }
    }
}

