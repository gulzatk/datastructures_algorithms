using System;
using System.Collections.Generic;

namespace relative_sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {2,3,1,3,2,4,6,1,9,2,19,5};
            int[] arr2 = {2,1,4,3,9,6};
            int[] result = RelativeSortArray(arr1, arr2);
            foreach (int n in result)
            {
                Console.Write(n + ",");
            }
        }
        static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            ISet<int> nonExisting = new HashSet<int>(arr2);
            Array.Sort(arr1);
            int curr = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        result[curr++] = arr1[j];
                    }
                }
            }
            foreach (int n in arr1)
            {
                if (!nonExisting.Contains(n))
                {
                    result[curr++] = n;
                }
            }
            return result;
        }
    }
}
