using System;
using System.Collections.Generic;

namespace string_matching_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "leetcode", "et", "code" };
            IList<string> result = StringMatching(words);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        static IList<string> StringMatching(string[] words)
        {
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            foreach (string s in words)
            {
                list.Add(s);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] != list[j] && list[i].Contains(list[j]))
                    {
                        if (!result.Contains(list[j]))
                        {
                            result.Add(list[j]);
                        }
                    }
                }
            }
            return result;

        }
    }
}
