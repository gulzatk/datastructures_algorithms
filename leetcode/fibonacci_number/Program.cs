using System;

namespace fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            int a = 0, b = 1, c = 1;
            while (n > 1)
            {
                c = a + b;
                a = b;
                b = c;
                n--;
            }
            return c;
        }
    }
}
