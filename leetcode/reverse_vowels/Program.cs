using System;

namespace reverse_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("leetcode"));
            Console.WriteLine(ReverseVowels("human"));
            Console.WriteLine(ReverseVowels("Aa"));
        }
        static string ReverseVowels(string s)
        {
            char[] characters = s.ToCharArray();
            int a = 0;
            int b = characters.Length-1;
            while (a < b)
            {
                if (!IsVowel(characters[a]))
                {
                    a++;
                    continue;
                }
                if (!IsVowel(characters[b]))
                {
                    b--;
                    continue;
                }
                char temp = characters[a];
                characters[a] = characters[b];
                characters[b] = temp;
                a++;
                b--;
            }
            return new string(characters);

        }
        static bool IsVowel(char ch)
        {
            return ch == 'a' || ch == 'e' || ch == 'u' || ch == 'i' || ch == 'o' ||ch == 'A' || ch == 'E' || ch == 'U' || ch == 'I' || ch == 'O';
        }
    }
}
