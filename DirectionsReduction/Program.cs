using System;
using System.Collections.Generic;
namespace DirectionsReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            dirReduc(a);
        }
        public static string[] dirReduc(String[] arr)
        {
            List<string> temp = new List<string>(arr);
            bool deleted = false;
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine(temp[i]);
                if (i != temp.Count - 1)
                {
                    if (temp[i] == "NORTH" && temp[i + 1] == "SOUTH")
                    {
                        temp.RemoveAt(i + 1);
                        temp.RemoveAt(i);
                        i = -1;
                    }
                    else if (temp[i] == "SOUTH" && temp[i + 1] == "NORTH")
                    {
                        temp.RemoveAt(i + 1);
                        temp.RemoveAt(i);
                        i = -1;
                    }
                    else if (temp[i] == "WEST" && temp[i + 1] == "EAST")
                    {
                        temp.RemoveAt(i + 1);
                        temp.RemoveAt(i);
                        i = -1;
                    }
                    else if (temp[i] == "EAST" && temp[i + 1] == "WEST")
                    {
                        temp.RemoveAt(i + 1);
                        temp.RemoveAt(i);
                        i = -1;
                    }
                }
            }
            arr = temp.ToArray();
            return arr;
        }
    }
}
