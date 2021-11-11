using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int num = 5;
            Console.WriteLine(Factorial(n));
            Console.WriteLine(FactorialRecursive(num));
        }

// using loop
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            int result = n;
            for (int i = n-1; i > 0; i--)
            {
                result = result * i; 
            }
            return result;
        }

        // using recursive
        public static int FactorialRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialRecursive(n - 1);
        }
    }
}
