using System;

namespace add_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(38));
            Console.WriteLine(AddDigits(382));
        }
        // Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
        static int AddDigits(int num)
        {
            while ((num / 10) != 0)
            {
                int remainder = num % 10;
                num = (num / 10) + remainder;
            }
            return num;
        }
    }
}
