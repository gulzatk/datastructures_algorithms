using System;
using System.Collections.Generic;

namespace greatest_number_of_candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candies = {2,3,5,1,3};
            int extraCandies = 3;
            IList<bool> result = KidsWithCandies(candies, extraCandies);
            foreach (bool r in result)
            {
                Console.WriteLine(r);
            }
        }

        static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int greatest = 0;
            foreach (int n in candies)
            {
                if (n > greatest)
                {
                    greatest = n;
                }
            }
            foreach (int n in candies)
            {
                result.Add(n + extraCandies >= greatest ? true : false);
            }
            return result;
        }
    }
}
