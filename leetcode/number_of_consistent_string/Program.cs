using System;
using System.Collections.Generic;

namespace number_of_consistent_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string allowed = "abc";
            string[] words = {"a","b","c","ab","ac","bc","abc"};
            Console.WriteLine(CountConsistentString(allowed, words));
        }
        static int CountConsistentString(string allowed, string[] words)
        {
            HashSet<char> set  = new HashSet<char>();
            char[] characters = allowed.ToCharArray();
            foreach (char ch in characters)
            {
                set.Add(ch);
            }
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int sPointer = 0;
                while (sPointer < words[i].Length)
                {
                    if (set.Contains(words[i][sPointer]))
                    {
                        sPointer++;
                    } else {
                        break;
                    }
                }
                if (sPointer == words[i].Length)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
