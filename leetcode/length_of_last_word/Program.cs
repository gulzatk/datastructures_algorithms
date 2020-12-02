using System;

namespace length_of_last_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello World!"));
            Console.WriteLine(LengthOfLastWord("Hello "));
            Console.WriteLine(LengthOfLastWord(" "));
        }
        static int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            s = s.TrimEnd();
            int lastindex = s.Length-1;
            int count = 0;
            while (lastindex >= 0 && s[lastindex] != ' ')
            {
                count++;
                lastindex--;
            }
            return count;
        }
    }
}
