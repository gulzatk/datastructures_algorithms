using System;
using System.Collections.Generic;

namespace minimum_absolute_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,2,1,3};
            var result = MinimumAbsDiff(nums);
            foreach (var item in result)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                    
                }
                Console.WriteLine();
            }
        }

        static IList<IList<int>> MinimumAbsDiff(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            int minDiff = Math.Abs(nums[0] - nums[1]);
            result.Add(new List<int>(){nums[0], nums[1]});
            for (int i = 1; i < nums.Length-1; i++)
            {
                int diff = Math.Abs(nums[i] - nums[i + 1]);
                if (minDiff < diff)
                {
                    result.Clear();
                    minDiff = diff;
                }
                if (minDiff == diff)
                {
                    result.Add(new List<int>(){nums[i], nums[i + 1]});
                }
            }
            return result;
        }
    }
}
