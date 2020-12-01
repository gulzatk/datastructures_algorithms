using System;
using System.Collections.Generic;

namespace find_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDifference("abcd", "abcde"));
            Console.WriteLine(FindTheDifference("a", "aa"));
            Console.WriteLine(FindTheDifference("ta", "tat"));
        }
        static char FindTheDifference (string s, string t)
        {
            if (s.Length == 0)
            {
                return t[0];
            }
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char i in t)
            {
                if (!d.ContainsKey(i))
                {
                    d.Add(i, 1);
                }else {
                    d[i]++;
                }                
            }
            foreach (char i in s)
            {
                d[i]--;
                if (d[i] == 0)
                {
                    d.Remove(i);
                }
            }
            char result = ' ';
            foreach (KeyValuePair<char, int> i in d)
            {
                 result = i.Key;
            }
           
            return result;
        }
    }
}
