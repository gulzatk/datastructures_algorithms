//Write a function to find the longest common prefix string amongst an array of string
//If there is no prefix return an empty string "".

using System;

namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flow", "flower", "fly"};
            Console.WriteLine(LongestCommonPrefix(strs));
        }

         static string LongestCommonPrefix(string[] strs)
         {
             if(strs.Length == 0){
                 return "";
             }for(int i=0; i<strs[0].Length; i++)
             {
                 foreach(String str in strs)
                 {
                     if(str.Length <= i)
                     {
                         return str;
                     }
                     if(str[i] != strs[0][i])
                     {
                         return str.Substring(0, i);
                     }
                 }
             }
             return strs[0];
         }

    }
}
