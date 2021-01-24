using System;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1,0,3,5,9,12};
            int target = 9;
            Console.WriteLine(BinarySearch(nums, target));
        }
        static int BinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int left = 0;
            int right = nums.Length-1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                if (target < nums[middle])
                {
                    right = middle -1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}

// case 1: int[] nums = {};
// case 2: int[] nums = null;
// case 3: int[] nums = {5}, target = 5;
