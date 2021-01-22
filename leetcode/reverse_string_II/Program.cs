using System;

namespace reverse_string_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("abc", 2));
            Console.WriteLine(ReverseString("abcdefg", 2));
        }
        static string ReverseString(string s, int k)
        {
            char[] str = s.ToCharArray();
            for (int i = 0; i < str.Length; i = i + 2*k)
            {
                int a = i;
                int b = i + k - 1 < str.Length-1 ? i + k - 1 : str.Length-1;
                while (a < b)
                {
                    char temp = str[a];
                    str[a] = str[b];
                    str[b] = temp;
                    a++;
                    b--;
                }
            }
            return new string(str);
        }
    }
}
