using System;

namespace search_insert_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,3,5,6};
            int target = 7;
            Console.WriteLine(SearchInsert(nums, target));
        }

        //Given a sorted array of distinct integers and a target value, return the index if the target is found. 
        //If not, return the index where it would be if it were inserted in order.

        static int SearchInsert(int[] nums, int target)
        {
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] < target)
                {
                    break;
                }else if( nums[i] >= target)
                {
                    return i;
                }
                
            }
            return nums.Length;
        }
    }
}
