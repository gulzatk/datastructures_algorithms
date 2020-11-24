using System;
using System.Collections.Generic;

namespace contains_duplicate_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,1,2,3,1,5};
            int k = 3;
            
            Console.WriteLine(ContainsNearbyDuplicate(nums, k));
        }
        static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
                if (i-k >= 0)
                {
                    set.Remove(nums[i-k]);
                }
            }
            return false;
        }
    }
}
