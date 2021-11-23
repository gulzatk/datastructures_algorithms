using System;

namespace houses_with_diff_colors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colors = {1,1,1,6,1,1,1};
            Console.WriteLine(MaxDistance(colors));
        }

        static int MaxDistance(int[] colors)
        {
            int a = 0, b = colors.Length-1, diff = 1;
            while (a < b)
            {
                int count = (colors.Length-1) - b;
                if (colors[a] != colors[b] && count <= Math.Abs(a - b))
                {
                    if (diff < Math.Abs(a - b))
                    {
                        diff = Math.Abs(a - b);
                    }
                }
                if (colors[a] != colors[b] && count > Math.Abs(a - b))
                {
                    if (diff < count)
                    {
                        diff = count;
                    }
                }
                b--;
            }
            return diff;
        }
    }
}
