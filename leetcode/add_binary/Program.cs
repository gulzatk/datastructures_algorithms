using System;

namespace add_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "110";
            string b = "1";
            Console.WriteLine(AddBinary(a,b));
        }

        static string AddBinary(string a, string b)
        {
            while (a.Length != b.Length)
            {
                if (a.Length > b.Length)
                {
                    b = "0" + b;
                }
                else
                {
                    a = "0" + a;
                }
            }
            int carryOver = 0;
            string result = "";
            for (int i = a.Length-1; i >= 0; i--)
            {
                int sum = (a[i] -'0') + (b[i] - '0') + carryOver;
                carryOver = sum / 2;
                result = (sum % 2) + result;
            }
            if (carryOver == 1)
            {
                result = carryOver + result;
            }
            return result;
        }
    }
}
