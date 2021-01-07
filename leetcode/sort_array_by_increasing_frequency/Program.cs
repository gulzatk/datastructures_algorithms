using System;
using System.Collections.Generic;
using System.Linq;

namespace sort_array_by_increasing_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,3,1,3,2};
            int[] result = FrequencySort(nums);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
        static int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (!dict.ContainsKey(n))
                {
                    dict.Add(n, 1);
                } else {
                    dict[n]++;
                }
            }
            List<KeyValuePair<int, int>> items = dict.ToList();
            items.Sort(CustomComparator);

            int index = 0;
            foreach (KeyValuePair<int, int> pair in items)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    nums[index] = pair.Key;
                    index++;
                }
            }
            return nums;
        }
        static int CustomComparator(KeyValuePair<int, int> a, KeyValuePair<int, int> b)
        {
            if (a.Value != b.Value)
            {
                return a.Value - b.Value;
            }
            return b.Key - a.Key;
        }
    }
}
