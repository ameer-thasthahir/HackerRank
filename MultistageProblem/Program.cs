using System;

namespace MultistageProblem
{
    public class MultistageGraph
    {
        public static void Main()
        {
            int stages = 4;
            int[] cost = new int[9];
            int n = 8;
            int[] d = new int[9];
            int[] v = new int[9];
            int min = 0;
            int[,] c = new int[9, 9]
            {
            {0,0,0,0,0,0,0,0,0},
            {0,0,2,1,3,0,0,0,0},
            {0,0,0,0,0,2,3,0,0},
            {0,0,0,0,0,6,7,0,0},
            {0,0,0,0,0,6,8,9,0},
            {0,0,0,0,0,0,0,0,6},
            {0,0,0,0,0,0,0,0,4},
            {0,0,0,0,0,0,0,0,5},
            {0,0,0,0,0,0,0,0,0}
            };

            cost[n] = 0;

            for (int i = n - 1; i <= n; i--)
            {
                for (int k = i + 1; k <= n; k++)
                {
                    if (c[i, k] != 0)
                    {
                        Console.WriteLine($"[{i}][{k}]");
                    }
                }
            }

            Console.Read();
        }
    }
}
