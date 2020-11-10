using System;

namespace largest_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxLengthBetweenEqualCharacters("adsabvb"));
        }
        // Given a string s, return the length of the longest substring between two equal characters, 
        // excluding the two characters. If there is no such substring return -1.
        static int MaxLengthBetweenEqualCharacters(string s) {
            int maxLen = -1;
            
            for (int i=0; i<s.Length-1; i++){
                for (int j=i+1; j<s.Length; j++){
                    if(s[i] == s[j]){
                        int count = j - i - 1; // get distance count between i to j
                        if(count > maxLen){
                            maxLen = count;
                        }
                    }
                }
            }
            return maxLen;

        }
    }
}
