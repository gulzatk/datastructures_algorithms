using System;
using System.Collections.Generic;

namespace valid_palindrome_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindrome("aba"));
            Console.WriteLine(ValidPalindrome("abca"));
            Console.WriteLine(ValidPalindrome("abc"));

        }
        static bool ValidPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return IsPalindrome(s, i + 1, j) || IsPalindrome(s, i, j - 1);
                }
                i++;
                j--;
            }
            return true;
        }
        static bool IsPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
