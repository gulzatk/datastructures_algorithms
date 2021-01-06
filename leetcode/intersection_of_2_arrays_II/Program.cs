using System;
using System.Collections.Generic;

namespace intersection_of_2_arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {4,9,5};
            int[] nums2 = {9,4,9,8,4};
            int[] result = Intersect(nums1, nums2);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
            
        }
        static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int n in nums1)
            {
                if (!dict.ContainsKey(n))
                {
                    dict.Add(n, 1);
                } else {
                    dict[n]++;
                }
            }

            List<int> result = new List<int>();
            foreach (int n in nums2)
            {
                if (dict.ContainsKey(n) && dict[n] > 0)
                {
                    result.Add(n);
                    dict[n]--;
                }
            }

            return result.ToArray();
        }
    }
}
