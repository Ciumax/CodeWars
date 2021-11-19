using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            ToRoman(1997);
            FromRoman("MCMXCVII");
        }

       public static string ToRoman(int n)
        { 
            string answer = "";
            while(n != 0)
            {
            if (n >= 1000) {answer += "M"; n = n - 1000; continue;}
            if (n >= 900) {answer += "CM"; n = n - 900; continue;}
            if (n >= 500) {answer += "D"; n = n - 500; continue;}
            if (n >= 400) {answer += "CD"; n = n - 400; continue;}
            if (n >= 100) {answer += "C"; n = n - 100; continue;}
            if (n >= 90) {answer += "XC"; n = n - 90; continue;}
            if (n >= 50) {answer += "L"; n = n - 50; continue;}
            if (n >= 40) {answer += "XL"; n = n - 40; continue;}
            if (n >= 10) {answer += "X"; n = n - 10; continue;}
            if (n >= 9) {answer += "IX"; n = n - 9; continue;}
            if (n >= 5) {answer += "V"; n = n - 5; continue;}
            if (n >= 4) {answer += "IV"; n = n - 4; continue;}
            if (n >= 1) {answer += "I"; n = n - 1; continue;}
            }
            return answer;
        }

    public static int FromRoman(string romanNumeral)
        {
            int answer = 0;
            for(int i = 0; i < romanNumeral.Length; i++)
            {
                if(i != romanNumeral.Length - 1)
                {
                if (romanNumeral[i] == 'C' && romanNumeral[i + 1] == 'M') { answer += 900; i++; continue;}
                if (romanNumeral[i] == 'C' && romanNumeral[i + 1] == 'D') { answer += 400; i++; continue;}
                if (romanNumeral[i] == 'X' && romanNumeral[i + 1] == 'C') { answer += 90; i++; continue;}
                if (romanNumeral[i] == 'X' && romanNumeral[i + 1] == 'L') { answer += 40; i++; continue;}
                if (romanNumeral[i] == 'I' && romanNumeral[i + 1] == 'X') {answer += 9; i++; continue;}
                if (romanNumeral[i] == 'I' && romanNumeral[i + 1] == 'V') {answer += 4; i++; continue;}
                }
                if (romanNumeral[i] == 'M') {answer += 1000; continue;} 
                if (romanNumeral[i] == 'D') { answer += 500; continue;}
                if (romanNumeral[i] == 'C') { answer += 100; continue;}
                if (romanNumeral[i] == 'L') { answer += 50; continue;}
                if (romanNumeral[i] == 'X') { answer += 10; continue;}
                if (romanNumeral[i] == 'X') { answer += 10; continue;}
                if (romanNumeral[i] == 'V') { answer += 5; continue;}
                if (romanNumeral[i] == 'I' ) {answer += 1; continue;}
            }
            return answer;
        }
    }
}
