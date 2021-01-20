using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = {'h', 'e', 'l', 'l', 'o'};
            Console.WriteLine(ReverseString(s));
        }
        static char[] ReverseString(char[] s)
        {
            int a = 0;
            int b = s.Length-1;
            while (a < b)
            {
                char temp = s[a];
                s[a] = s[b];
                s[b] = temp;
                a++;
                b--;
            }
            return s;
        }
    }
}
