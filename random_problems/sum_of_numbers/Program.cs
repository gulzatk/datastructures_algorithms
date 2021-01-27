using System;

namespace sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNumbers("Jibek123 Emil 456"));
        }
        static int SumOfNumbers(string s)
        {   
            if (s == null || s == "")
            {
                return 0;
            }      
            int sum = 0;
            string number = "";
            foreach (char ch in s)
            {
                if (Char.IsDigit(ch))
                {
                    number += ch;
                } else 
                {
                    if (number != "")
                    {
                        sum += int.Parse(number);
                        number = "";
                    }
                }
            }

            if (number != "")
            {
                sum += int.Parse(number);
            }
            
            return sum;
        }
    }
}
// case 1: s = null;
// case 2: s = "";
// case 3: s = "Jibek Emilbek";
// case 4: s = "123 456";


