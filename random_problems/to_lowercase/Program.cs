using System;
using System.Text;

namespace to_lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLower("HelLo World!"));
        }
        static string ToLower(string s)
        {
            StringBuilder result = new StringBuilder();
            int difference = 'A' - 'a';
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    result.Append((char)(s[i] - difference));
                } else{
                    result.Append(s[i]);
                }
            }
            return result.ToString();
        }
    }    
}
