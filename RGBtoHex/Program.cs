using System;
using System.Drawing;

namespace RGBtoHex
{
    public class Kata
    {
        static void Main(string[] args)
        {
            Kata.Rgb(148, 0, 211);
        }
        public static string Rgb(int r, int g, int b)
        {
            if(r > 255) r = 255;
            if(g > 255) g = 255;
            if(b > 255) b = 255;
            if(r < 0) r = 0;
            if(g < 0) g = 0;
            if(b < 0) b = 0;
            string hexValue = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            return hexValue;
        }
    }
}
