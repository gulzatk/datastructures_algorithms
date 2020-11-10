using System;
using System.Text;

namespace add_string_by_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("100", "9000"));
        }
        static string Reverse(string str){
            StringBuilder reversed = new StringBuilder();
            for(int i = str.Length-1; i >= 0; i--){
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }
        static string AddStrings(string num1, string num2){
            StringBuilder result = new StringBuilder();
            int remainder = 0;
            num1 = Reverse(num1);
            num2 = Reverse(num2);

            int maxLen = (num1.Length > num2.Length)? num1.Length : num2.Length;
            for (int i = 0; i < maxLen; i++){
                int num1Val = 0;
                if (i < num1.Length){
                    num1Val = (int)(num1[i] - '0');
                }
                int num2Val = 0;
                if (i < num2.Length) {
                    num2Val = (int)(num2[i] - '0');
                }
                int sum = (num1Val + num2Val + remainder);
                result.Append(sum % 10); 
                remainder = sum / 10;
            }
            if (remainder > 0){
                result.Append(remainder);
            }
            return Reverse(result.ToString());

        }
    }
}
