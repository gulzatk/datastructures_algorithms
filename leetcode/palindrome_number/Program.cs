using System;

namespace palindrome_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(12321));
        }

        static bool IsPalindrome(int x)
        {
            int temp = x;
            int sum = 0;
            while(x > 0)
            {
            int reminder = x % 10;
            sum = sum * 10 + reminder;
            x = x / 10;
            }

            if(temp == sum)
            {
                return true;
            }
            return true;
        }
    }
}
