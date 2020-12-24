using System;

namespace equivalent_string_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word1 = {"ab", "c"};
            string[] word2 = {"a", "bc"};
            Console.WriteLine(ArrayStringAreEquivalent(word1, word2));
        }
        static bool ArrayStringAreEquivalent(string[] word1, string[] word2 )
        {
            int a1 = 0, a2 = 0;
            int s1 = 0, s2 = 0;
            while(a1 < word1.Length && a2 < word2.Length)
            {
                if (word1[a1][s1] != word2[a2][s2])
                {
                    return false;
                }
                if (s1 == word1[a1].Length-1)
                {
                    a1++;
                    s1 = 0;
                } else {
                    s1++;
                }
                if (s2 == word2[a2].Length-1)
                {
                    a2++;
                    s2 = 0;
                } else {
                    s2++;
                }
            }
            return a1 == word1.Length && a2 == word2.Length;
        }
    }
}
