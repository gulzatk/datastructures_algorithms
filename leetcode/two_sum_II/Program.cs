using System;

namespace two_sum_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,3,4};
            int target = 6;
            TwoSum(nums, target);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            } 
            
        }
        static int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int j = nums.Length-1;
            while (i <= j)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{i+1, j+1};
                }
                if (nums[i] + nums[j] < target)
                {
                    i++;
                } else {
                    j--;
                }
            }
            return new int[]{i+1, j+1};
        }
    }
}
