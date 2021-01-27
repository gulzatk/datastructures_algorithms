using System;

namespace repeated_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedLetters("hello"));
        }
        static string RepeatedLetters(string s)
        {
            int[] counter = new int[26];
            string result = "";
            foreach (char ch in s)
            {
                counter[ch - 'a']++;
                if (counter[ch -'a'] > 1)
                {
                    result = ch.ToString();
                }
            }
            return result;
        }
    }
}
