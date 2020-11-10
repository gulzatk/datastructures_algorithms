// Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.
//Note:
// The length of both num1 and num2 is < 5100.
// Both num1 and num2 contains only digits 0-9.
// Both num1 and num2 does not contain any leading zero.
// You must not use any built-in BigInteger library or convert the inputs to integer directly.

using System;

namespace add_string
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(AddStrings("1000", "999"));
        }

        static string AddStrings(string num1, string num2){
            string result = "";
            int remainder = 0;

// find maxLength;
            if(num1.Length > num2.Length){
                string temp = num1;
                num1 = num2;
                num2 = temp; 
            }

            for (int i = num1.Length-1; i >= 0; i--){
                int n1 = (int)(num1[i] - '0');
                int n2 = (int)(num2[i + num2.Length - num1.Length] - '0'); 
                int sum = (n1 + n2 + remainder);
                result = (sum % 10) + result;
                remainder = sum / 10;
            }
            for (int i = num2.Length - num1.Length - 1; i >= 0; i--){
                int n1 = (int)(num2[i] - '0');
                int sum = n1 + remainder;
                result = (sum % 10) + result;
                remainder = sum / 10;
            }
            if( remainder > 0){
                result = remainder + result;
            }
            return result;
        }
    }
}
