using System;

namespace repeated_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,2,4};
            Console.WriteLine(RepeatedNumber(numbers));
        }
        static int RepeatedNumber(int[] numbers)
        {
            if (numbers == null && numbers.Length == 0)
            {
                return 0;
            }
            int[] counter = new int[numbers.Length];

            foreach (int n in numbers)
            {
                counter[n]++;
                if (counter[n] > 1)
                {
                    return n;
                }
            }
            return 0;
        }
    }
}
