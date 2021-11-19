using System;

namespace greatest_element_on_the_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {17,18,5,4,6,1};
            int[] result = ReplaceElements(nums);
            foreach (int n in result)
            {
                Console.Write(n +", ");
            }
        }
        
        static int[] ReplaceElements(int[] nums)
        {
            int greatest = nums[nums.Length-1];
            nums[nums.Length-1] = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                int tmp = nums[i];
                nums[i] = greatest;
                greatest = Math.Max(tmp, greatest);
            }
            return nums;
        }
    }
}
