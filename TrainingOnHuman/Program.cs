using System;

namespace TrainingOnHuman
{
    public static class TimeFormat
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            TimeFormat.GetReadableTime(86399);
            TimeFormat.GetReadableTime(359999);
            TimeFormat.GetReadableTime(60);
            TimeFormat.GetReadableTime(5);
        }

        public static string GetReadableTime(int seconds)
        {
            int[] hoursMinutesSeconds = { -1, -1, -1 };
            int checker = 0;
            int test = 0;
            while (checker <= seconds)
            {
                checker = checker + 3600;
                hoursMinutesSeconds[0]++;
            }
            checker -= 3600;
            test = seconds - checker;
            checker = 0;
            while (checker <= test)
            {
                checker = checker + 60;
                hoursMinutesSeconds[1]++;
            }

            checker -= 60;
            hoursMinutesSeconds[2] = test - checker;
            string result = "";
            foreach (var item in hoursMinutesSeconds)
            {
                result += item.ToString("D2") + ":";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
    }
}

