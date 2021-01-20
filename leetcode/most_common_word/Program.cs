using System;
using System.Collections.Generic;

namespace most_common_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = {"hit"};
            Console.WriteLine(MostCommonWord(paragraph, banned));
        }
        static string MostCommonWord(string paragraph, string[] banned) {
            HashSet<string> mySet = new HashSet<string>(banned);
            string[] words = paragraph.Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace("!", " ").Replace("?", " ").Replace("'", " ").ToLower().Split(" ");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (mySet.Contains(word) || word =="")
                {
                    continue;
                }
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                } else{
                    dict[word]++;
                }
            }
            int count = 0;
            string result = "";
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (pair.Value > count)
                {
                    count = pair.Value;
                    result = pair.Key;
                }
            }
            return result;
        }
    }
}
