using System;

namespace plus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = {1,2,3};
            PlusOne(digits);
            foreach (int i in digits)
            {
                Console.WriteLine(i);
            }
            
        }
        static int[] PlusOne(int[] digits)
        {
            int last = digits.Length-1;
            int carryOver = 0;
            while (last >= 0)
            {
                carryOver = (digits[last] + 1) / 10;
                digits[last] = (digits[last] + 1) % 10;
                if (carryOver == 0)
                {
                    break;
                }
                last--;
            }
            if (carryOver > 0)
            {
                int[] newDigits = new int[digits.Length+1];
                newDigits[0] = carryOver;
                for (int i = 1; i < newDigits.Length; i++)
                {
                    newDigits[i] = digits[i-1];
                }
                return newDigits;
            }
            return digits;
        }
    }
}
