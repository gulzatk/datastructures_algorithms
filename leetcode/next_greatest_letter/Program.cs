using System;

// Given a characters array letters that is sorted in non-decreasing order and a character target, return the smallest character in the array that is larger than target.

namespace next_greatest_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = {'c','f','j'};
            char target = 'd';
            Console.WriteLine(NextGreatestLetter(letters, target));
        }

        static char NextGreatestLetter(char[] letters, char target)
        {
            foreach (char n in letters)
            {
                if (n > target)
                {
                    return n;
                }
            }
            return letters[0];
        }
    }
}
