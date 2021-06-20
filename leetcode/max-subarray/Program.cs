﻿using System;

namespace max_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
            Console.WriteLine(MaxSubArray(nums));
        }

        static int MaxSubArray(int[] nums)
        {
            int result = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum+=nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > result)
                {
                    result = sum;
                }
            }
            return result;
        }
    }
}
