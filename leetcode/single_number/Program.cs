using System;
using System.Collections.Generic;

namespace single_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2};
            Console.WriteLine(SingleNumber(nums));

            
        }
        static int SingleNumber(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            if (nums.Length == 1)
            {
                return nums[0];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                {
                    result.Remove(nums[i]);
                } else {
                    result.Add(nums[i]);
                }
            }
            int single = 0;
            foreach(int i in result)
            {
                single = i;
            }
            return single;
        }
    }
}
