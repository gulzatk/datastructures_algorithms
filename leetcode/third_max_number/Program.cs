
//Given a non-empty array of integers, return the third maximum number in this array. 
//If it does not exist, return the maximum number. The time complexity must be in O(n).
using System;

namespace third_max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {3,3,2,-1};
            //int[] nums = {3,3,2};
            int[] nums = {9, 6, 4, 7};
            Console.WriteLine(ThirdMax(nums));
        }
        static int ThirdMax(int[] nums){
            long firstMax = long.MinValue;
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;

            for(int i=0; i<nums.Length; i++){
                if(nums[i] > firstMax){
                    firstMax = nums[i];
                }
            }
            for(int i=0; i< nums.Length; i++){
                if(nums[i] > secondMax && nums[i] < firstMax){
                    secondMax = nums[i];
                }
            }
            for(int i=0; i<nums.Length; i++){
                if(nums[i] > thirdMax && nums[i] < secondMax){
                    thirdMax = nums[i];
                }
            }
            if(thirdMax < long.MinValue){
                return (int) firstMax;
            }
            return (int) thirdMax;
        }
    }

}
