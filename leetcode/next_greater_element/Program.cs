using System;

namespace next_greater_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {4,1,2};
            int[] nums2 = {1,3,4,2};
            int[] result = NextGreaterElement(nums1, nums2);
            foreach (int n in result)
            {
                Console.Write(n + ",");
            }
        }
        static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                int index = Array.IndexOf(nums2, nums1[i]);
                if (index == nums2.Length-1)
                {
                    nums1[i] = -1;
                }
                for (int j = index + 1; j < nums2.Length; i++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        nums1[i] = nums2[j];
                        break;
                    }
                    if (j + 1 >= nums2.Length)
                    {
                        nums1[i] = -1;
                    }
                }
            }
            return nums1;
        }
    }
}
