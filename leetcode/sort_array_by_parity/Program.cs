using System;
using System.Collections.Generic;

namespace sort_array_by_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 2, 4 };
            int[] result = SortArrayByParity(A);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

        }
        static int[] SortArrayByParity(int[] A)
        {
            List<int> result = new List<int>();

            foreach (int n in A)
            {
                if (n % 2 == 0)
                {
                    result.Insert(0, n);
                }
                else
                {
                    result.Add(n);
                }
            }
            return result.ToArray();
        }
    }
}
