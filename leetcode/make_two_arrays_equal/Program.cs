using System;
using System.Collections.Generic;

namespace make_two_arrays_equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = {1,2,3,4};
            int[] arr = {1,3,2,1};
            Console.WriteLine(CanBeEqual(target, arr));
        }
        static bool CanBeEqual(int[] target, int[] arr)
        {
            if(target.Length != arr.Length)
            {
                return false;
            }
            Dictionary<int, int> targetDict = Convert(target);
            Dictionary<int, int> arrDict = Convert(arr);

            foreach(int i in targetDict.Keys)
            {
                if(!arrDict.ContainsKey(i) || targetDict[i] != arrDict[i])
                {
                    return false;
                }
            }
            foreach(int i in arrDict.Keys)
            {
                if(!targetDict.ContainsKey(i) || targetDict[i] != arrDict[i])
                {
                    return false;
                }
            }
            return true;
        }
        static Dictionary<int, int> Convert(int[] array)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach(int i in array)
            {
                if (!result.ContainsKey(i))
                {
                    result[i] = 0;
                }
                result[i]++;
            }
            return result;
           
        }
    }
}
