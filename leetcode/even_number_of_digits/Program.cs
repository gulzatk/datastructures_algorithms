using System;

namespace even_number_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {12, 123, 2, 1234};

            Console.WriteLine(FindNumbers(nums));
        }
        static int FindNumbers(int[] nums)
        {
            int evenDigits = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                while (nums[i] != 0)
                {
                    nums[i] = nums[i] / 10;
                    count++;
                }
                if (count % 2 == 0)
                {
                    evenDigits++;
                }
            }
            return evenDigits;
        }
    }
}
