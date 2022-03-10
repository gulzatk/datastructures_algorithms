using System;

namespace busy_mall
{
    class Program
    {
        static void Main(string[] arg)
        {
            int[,] data = { {1487799425, 14, 1}, 
                         {1487799425, 4,  0},
                         {1487799425, 2,  0},
                         {1487800378, 10, 1},
                         {1487801478, 18, 0},
                         {1487801478, 18, 1},
                         {1487901013, 1,  0},
                         {1487901211, 7,  1},
                         {1487901211, 7,  0} };
    
            Console.WriteLine(FindBusiestPeriod(data));
        }

        static int FindBusiestPeriod(int[,] data)
        {
            int maxTime = 0;
            int currCount = 0;
            int maxCount = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == 1)
                {
                    currCount += data[i, 1];
                }
                else if (data[i, 2] == 0)
                {
                    currCount -= data[i, 1];
                }

                if (i < data.GetLength(0) - 1 && data[i, 0] == data[i+1, 0])
                {
                    continue;
                }
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    maxTime = data[i, 0];
                }
            }
            return maxTime;
        }
    }
}
