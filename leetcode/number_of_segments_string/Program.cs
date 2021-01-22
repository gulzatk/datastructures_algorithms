using System;

namespace number_of_segments_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSegments("hello"));
            Console.WriteLine(CountSegments("hello, world "));
            Console.WriteLine(CountSegments("   "));
        }
        static int CountSegments(string s)
        {
            if (s == "")
            {
                return 0;
            }
            string[] str = s.Split(" ");
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == "")
                {
                    continue;
                }
                count++;
            }
            return count;
        }
    }
}
