using System;
using System.Collections.Generic;

namespace happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
             // Console.WriteLine(IsHappy(2));
             Console.WriteLine(IsHappy(19));
           //  Console.WriteLine(IsHappy(100));
        }
        static bool IsHappy(int n)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            while (n != 1)
            {
                if (dic.ContainsKey(n))
                {
                    return false;
                }
                int sum = 0;
                while (n != 0)
                {
                    int remainder = n % 10;
                    sum = sum + (remainder * remainder);
                    n = n / 10;
                }
                dic[n] = sum;
                n = sum;
            }
            return true;
        }
    }
}
