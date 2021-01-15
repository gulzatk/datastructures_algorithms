using System;
using System.Collections.Generic;

namespace reverse_only_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversLetters("ab-cd"));
            Console.WriteLine(ReversLetters("a-bC-dEf-ghIj"));
            Console.WriteLine(ReversLetters("Test1ng-Leet=code-Q!"));
        }
        static string ReversLetters(string S)
        {
            char[] result = S.ToCharArray();
            int a = 0; int b = result.Length - 1;
            while (a <= b)
            {
                if (!Char.IsLetter(result[a]))
                {
                    a++;
                    continue;
                }
                if (!Char.IsLetter(result[b]))
                {
                    b--;
                    continue;
                }
                char temp = result[a];
                result[a] = result[b];
                result[b] = temp;
                a++;
                b--;
            }
            return new String(result);
        }
    }
}
