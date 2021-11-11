using System;

namespace can_plant_flower
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = {1,0,0,0,1};
            int n = 2;
            Console.WriteLine(CanPlaceFlower(flowerbed, n));
        }

        static bool CanPlaceFlower(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if ((i - 1 < 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (i + 1 == flowerbed.Length || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            return n <= 0;
        }
    }
}
