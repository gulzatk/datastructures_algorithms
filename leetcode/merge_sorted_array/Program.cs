using System;

namespace merge_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {2,0};
            int m = 1;
            int[] nums2 = {1};
            int n = 1;
            Merge(nums1, m, nums2, n);
           foreach(int i in nums1)
           {
               Console.WriteLine(i);
           }
            
        }
        static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int a = m-1;
            int b = n-1; 
            int c = nums1.Length-1;
            while (a >= 0 && b >= 0)
            {
                if (nums1[a] < nums2[b])
                {
                    nums1[c] = nums2[b];
                    b--;
                }else {
                    nums1[c] = nums1[a];
                    a--;
                }
                c--;
            }
            while (b >= 0)
            {
                nums1[c] = nums2[b];
                c--;
                b--;
            }
             while (a >= 0)
            {
                nums1[c] = nums1[a];
                c--;
                a--;
            }
         
            return nums1;             
        }
    }
}
