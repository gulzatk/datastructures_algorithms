using System;

namespace balanced_string_split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "RLRRLLRLRL";
            Console.WriteLine(BalancedStringSplit(str));
        }

        static int BalancedStringSplit(string str)
        {
            int count = 0, r = 0, l = 0;
            foreach (char c in str)
            {
                if (c == 'R')
                {
                    r++;
                }
                else
                {
                    l++;
                }
                if (r == l)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
