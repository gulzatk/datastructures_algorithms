using System;

namespace remove_duplicates_sortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,2,3,3,3,4};
            Console.WriteLine(RemoveDuplicates(nums));
        }


        static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length-1 || nums[i] != nums[i + 1])
                {
                    nums[temp++] = nums[i];
                }

            }           
            
            return temp;
        }

    }
}
