using System;

namespace climbing_stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(ClimbStairs(n));
        }

        static int ClimbStairs(int n) {
            if (n <= 2)
            {
                return n;
            }
            int[] step = new int[n + 1];
            step[0] = 1;
            for (int i = 1; i < step.Length; i++)
            {
                step[i] = step[i - 1] + (i - 2 >= 0 ? step[i - 2] : 0);
            }
            return step[n];
        }
    }
}
