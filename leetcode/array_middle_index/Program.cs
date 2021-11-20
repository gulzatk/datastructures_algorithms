using System;

namespace array_middle_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,-1,2,2,8,4};
            Console.WriteLine(FindMiddleIndex(nums));
        }

        static int FindMiddleIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int rightSum = 0;
            foreach (int n in nums)
            {
                rightSum += n;
            }
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
