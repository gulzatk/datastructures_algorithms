using System;
using System.Collections.Generic;

namespace valid_anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
            Console.WriteLine(IsAnagram("aa", "a"));
            Console.WriteLine(IsAnagram("an", "na"));
            Console.WriteLine(IsAnagram("accac", "aacac"));
        }
        static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char i in s)
            {
                if (!d.ContainsKey(i))
                {
                    d.Add(i, 1);
                } else {
                    d[i]++; 
                }              
            }
            foreach (char i in t)
            {
                if (!d.ContainsKey(i))
                   {
                       return false;
                   }
                d[i]--;
            }

            return d.Count != 0;
        }
    }
}
