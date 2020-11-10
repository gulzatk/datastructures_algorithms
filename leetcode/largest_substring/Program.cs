using System;

namespace largest_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxLengthBetweenEqualCharacters("adsabvb"));
        }
        static int MaxLengthBetweenEqualCharacters(string s) {
            int maxLen = -1;
            
            for (int i=0; i<s.Length-1; i++){
                for (int j=i+1; j<s.Length; j++){
                    if(s[i] == s[j]){
                        int count = j - i - 1;
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
