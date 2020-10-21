using System;
using System.Collections.Generic;

namespace roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
            
        }

        static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumerals = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
            int sum = 0;
            char previousChar = s[0];
            foreach (char letter in s)
            {
                if (romanNumerals[previousChar] < romanNumerals[letter])
                {
                    sum -= romanNumerals[previousChar];
                    sum += romanNumerals[letter] - romanNumerals[previousChar];
                }
                else
                {
                    sum += romanNumerals[letter];
                }
                previousChar = letter;
            }
            return sum;
        }
    }
}
