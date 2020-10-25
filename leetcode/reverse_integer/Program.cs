using System;

namespace reverse_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123));
            Console.WriteLine(Reverse(-123));
          
        }

        static int Reverse(int x)
        {
            long reverted = 0;
            while(x != 0)
            {
                int reminder = x % 10;
                reverted = reverted * 10 + reminder;
                x = x / 10;
            }
            if(reverted > Int32.MaxValue || reverted < Int32.MinValue)
            {
                return 0;
            }
            return (int)reverted;
        }
    }
}
