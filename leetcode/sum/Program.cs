using System;
using System.Collections.Generic;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 8, 4};
            Console.WriteLine(string.Join(", ", Sum(nums, 6)));
        }

        static int[] Sum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] {i, dict[target - nums[i]]};
                }
                dict[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
