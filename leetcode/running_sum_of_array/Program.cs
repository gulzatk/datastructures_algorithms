using System;
using System.Collections;

namespace running_sum_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,4};
            int[] result = RunningSum(nums);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

// Return the running sum of nums.

        static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }
}
