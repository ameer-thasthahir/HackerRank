using System;
using System.Collections.Generic;

namespace MultistageProblem
{
    public class MultistageGraph
    {
        public static void Main()
        {
            // int min = int.MaxValue;
            // int[] cost = new int[9];
            // int n = 8;
            // int[] d = new int[9];
            // int[] v = new int[9];
            // int[,] c = new int[9, 9]
            // {
            // {0,0,0,0,0,0,0,0,0},
            // {0,0,2,1,3,0,0,0,0},
            // {0,0,0,0,0,2,3,0,0},
            // {0,0,0,0,0,6,7,0,0},
            // {0,0,0,0,0,6,8,9,0},
            // {0,0,0,0,0,0,0,0,6},
            // {0,0,0,0,0,0,0,0,4},
            // {0,0,0,0,0,0,0,0,5},
            // {0,0,0,0,0,0,0,0,0}
            // };

            // cost[n] = 0;

            // for (int i = n - 1; i >= 1; i--)
            // {
            //     for (int k = i + 1; k <= n; k++)
            //     {
            //         if (c[i, k] != 0 && (c[i, k] + cost[k]) < min)
            //         {
            //             min = c[i, k] + cost[k];
            //             d[i] = k;
            //         }
            //     }
            //     cost[i] = min;

            // }

            // Console.Read();
            List<long> arr = new List<long>() { 41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11 };            
            int n = 250;
            Console.Write(count(n,arr));
        }

        static int count(int n, List<long> S)
        {
            // table[i] will be storing the  
            // number of solutions for value i. 
            // We need n+1 rows as the table  
            // is constructed in bottom up manner 
            // using the base case (n = 0) 
            int[] table = new int[n + 1];
            int m = S.Count;

            // Base case (If given value is 0) 
            table[0] = 1;

            // Pick all coins one by one and  
            // update the table[] values after  
            // the index greater than or equal  
            // to the value of the picked coin 
            for (int i = 0; i < m; i++)
                for (long j = S[i]; j <= n; j++)
                    table[j] += table[System.Math.Abs(j - S[i])];

            return table[n];
        }
      


    }
}
