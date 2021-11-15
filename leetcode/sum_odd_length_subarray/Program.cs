using System;

// Given an array of positive integers arr, calculate the sum of all possible odd-length subarrays.
namespace sum_odd_length_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,4,2,5,3};
            Console.WriteLine(SumOddLengthSubarrays(nums));
        }
        static int SumOddLengthSubarrays(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if ((j - i + 1) % 2 == 1)
                    {
                        result += sum;
                    }
                }
            }
            return result;
        }
    }
}
