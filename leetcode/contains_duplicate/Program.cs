using System;
using System.Collections.Generic;


namespace contains_duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,4};
            Console.WriteLine(ContainsDuplicate(nums));
        }
// Given an array of integers, find if the array contains any duplicates.

// Your function should return true if any value appears at least twice in the array, 
// and it should return false if every element is distinct.
        static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                } else {
                    set.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
