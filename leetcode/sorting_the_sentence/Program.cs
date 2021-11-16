using System;

namespace sorting_the_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
           string s = "is2 sentence4 This1 a3";
           Console.WriteLine(SortSentence(s));
        }

        static string SortSentence(string s)
        {
            string[] str = s.Split(' ');
            string[] result = new string[str.Length];
            foreach (string item in str)
            {
                int index = (item[item.Length-1] - '0') - 1;
                result[index] = item.Remove(item.Length - 1, 1);
            }
            return string.Join(" ", result);
        }
    }
}
