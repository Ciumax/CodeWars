﻿using System;

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null || a.Length != b.Length)
        {
            return false;
        }
        Array.Sort (a);
        Array.Sort (b);
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != Math.Sqrt(b[i]))
            {
                count++;
            }
        }
        if (count != 0)
            return false;
        else
            return true;
    }
}
