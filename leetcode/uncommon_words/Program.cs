using System;
using System.Collections.Generic;

namespace uncommon_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "this apple is sweet";
            string s2 = "this apple is sour";
            string[] result = UncommonFromSentence(s1, s2);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string[] UncommonFromSentence(string s1, string s2)
        {
            string[] str1 = s1.Split(" ");
            string[] str2 = s2.Split(" ");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(string s in str1)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            foreach(string s in str2)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            List<string> result = new List<string>();
            foreach(var pair in dict)
            {
                if (pair.Value == 1)
                {
                    result.Add(pair.Key);
                }
            }

            return result.ToArray();
        }
    }    
}
