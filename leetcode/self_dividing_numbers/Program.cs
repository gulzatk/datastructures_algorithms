using System;
using System.Collections.Generic;

namespace self_dividing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> result = SelfDividingNumbers(1, 15);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }

        static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        static bool isSelfDividing(int number)
        {
            int n = number;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit == 0 || number % digit != 0)
                {
                    return false;
                }
                n = n / 10;
            }
            return true;
        }
    }
}
