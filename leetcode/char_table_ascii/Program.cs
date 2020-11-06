using System;

namespace char_table_ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get ASCII table index of the char
            char value = 'A';
            Console.WriteLine((int) value);

            // Convert char uppercase letter to order in the alpabet.
            string ch = "ABCD";
            for(int i=0; i<ch.Length; i++){
                int convertedIndex = (int) ch[i] - 'A' + 1;
                Console.WriteLine($"Letter: {ch[i]}, Index: {convertedIndex}");
            }

            // Convert char digit to the Integer digit.
            string num = "1234";
            for(int i=0; i<num.Length; i++){
                int convertedDigit = (int) num[i] - '0';
                Console.WriteLine($" String: {num[i]}, Integer: {convertedDigit}");
            }

            // Uppercase <-> Lowercase conversion
            string uppercase = "ABCD";
            string lowercase = "efgh";
            for(int i=0; i<uppercase.Length; i++){
                char convertedValue = (char) (uppercase[i] + 32);
                Console.WriteLine($"Uppercase: {uppercase[i]}, Lowercase: {convertedValue}");
            }
            for(int i=0; i<lowercase.Length; i++){
                char result = (char) (lowercase[i] - 32);
                Console.WriteLine($"Lowercase: {lowercase[i]}, Uppercase: {result}");
            }
            
        }
    }
}
