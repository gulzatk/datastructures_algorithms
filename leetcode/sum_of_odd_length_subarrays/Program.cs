using System;

namespace sum_of_odd_length_subarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3};
            Console.WriteLine(SumOddLengthSubarrays(arr));
        }
        /*Given an array of positive integers arr, calculate the sum of all possible odd-length subarrays.

        A subarray is a contiguous subsequence of the array.

        Return the sum of all odd-length subarrays of arr.
        */
        static int SumOddLengthSubarrays(int[] arr) 
        {
            int sum = 0;
            for (int start = 0; start < arr.Length; start++)
            {
                for (int end = start + 1; end <= arr.Length; end += 2)
                {
                    for (int i = start; i < end; i++)
                    {
                        sum = sum + arr[i];
                    }
                }
            }
            return sum;
        }
    }
}
