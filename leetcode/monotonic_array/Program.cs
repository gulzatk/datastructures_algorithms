using System;

namespace monotonic_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {4,3,2};
            Console.WriteLine(IsMonotonic(A));
        }
// An array is monotonic if it is either monotone increasing or monotone decreasing.
// Return true if the given A array is monotonic.

        static bool IsMonotonic(int[] A)
        {
            int length = A.Length;
            if (A[0] < A[length-1])
            {
                for (int i = 0; i < length-1; i++)
                {
                    if (A[i] > A[i+1])
                    {
                        return false;
                    }
                }
            } else {
                for (int i = 0; i < length-1; i++)
                {
                    if (A[i] < A[i+1])
                    return false;
                }
            }
            return true;
        }
    }
}
