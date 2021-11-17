using System;
using System.Collections.Generic;

namespace shortest_to_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "loveleetcode";
            char c = 'e';
            int[] result = ShortestToChar(s, c);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
        static int[] ShortestToChar(string s, char c)
        {
            int[] result = new int[s.Length];
            List<int> myList = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    myList.Add(i);
                }
            }
            int pointer = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (pointer < myList.Count - 1 && Math.Abs(myList[pointer] - j) > Math.Abs(myList[pointer + 1] - j))
                {
                    pointer++;
                }
                result[j] = Math.Abs(myList[pointer] - j);
            }
            return result;
        }
    }
}
