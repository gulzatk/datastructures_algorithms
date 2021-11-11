using System;
using System.Collections.Generic;

namespace find_restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list1 = {"Shogun","Tapioca Express","Burger King","KFC"};
            string[] list2 = {"KFC","Burger King","Tapioca Express","Shogun"};
            string[] result = FindRestaurant(list1, list2);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> str = new List<string>();
            List<string> result = new List<string>();
            foreach (string s in list1)
            {
                str.Add(s);
            }   
            int sum = int.MaxValue;
            for (int i = 0; i < list2.Length; i++)
            {
                if (str.Contains(list2[i]))
                {
                    int index = str.IndexOf(list2[i]);
                    if (i + index < sum)
                    {
                        result.Clear();
                        result.Add(list2[i]);
                        sum = i + index;
                    } 
                    else if (i + index == sum)
                    {
                        result.Add(list2[i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
