using System;
using System.Text;

namespace valid_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));
        }
        static bool IsPalindrome(string s)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i]))
                {
                    str.Append(s[i]);
                }
            }
            s = str.ToString().ToLower();
            int j = 0; 
            int k = s.Length-1;
            while (j <= k)
            {
                if (s[j] != s[k])
                {
                    return false;
                }
                j++; 
                k--;
            }
            return true;

        }
    }
}
