using System;

// Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

namespace duplicate_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,0,2,3,0,4,5,0};
            int[] result = DuplicateZeros(arr);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
        static int[] DuplicateZeros(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0, j = 0; j < result.Length-1; i++, j++)
            {
                if (arr[i] == 0)
                {
                    result[j] = arr[i];
                    result[j + 1] = 0;
                    j++;
                }
                else
                {
                    result[j] = arr[i];
                }
                if (j == result.Length-2)
                {
                    result[j + 1] = arr[i + 1];
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                arr[i] = result[i];
            }
            return arr;
        }
    }
}
