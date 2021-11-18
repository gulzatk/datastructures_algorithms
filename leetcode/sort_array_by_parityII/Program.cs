using System;

namespace sort_array_by_parityII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,2,5,7};
            int[] result = SortArrayByParityII(nums);
            foreach (int n in result)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
        }
        static int[] SortArrayByParityII(int[] nums)
        {
            int a = 0;
            int b = nums.Length-1;
            // move all even to left, odd to right
            while (a < b)
            {
                if (nums[a] % 2 == 0)
                {
                    a++;
                    continue;
                }
                if (nums[b] % 2 == 1)
                {
                    b--;
                    continue;
                }
                int tmp = nums[a];
                nums[a] = nums[b];
                nums[b] = tmp;
                a++;
                b--;
            }
            a = 1;
            b = nums.Length-2;
            while (a < b)
            {
                int tmp = nums[a];
                nums[a] = nums[b];
                nums[b] = tmp;
                a += 2;
                b -= 2;
            }
            return nums;
        }
    }
}
