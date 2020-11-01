using System;
using System.Collections.Generic;

namespace CountingCoins
{
    class Program
    {
        public static long getWays(int n, List<long> coins)
        {
            int[] collection = new int[n + 1];
            collection[0] = 1;
            foreach (var coin in coins)
            {
                for (long amount = 1; amount <= n; amount++)
                {
                    if (amount >= coin)
                    {   
                        var value = amount - coin;
                        if (value >= 0)
                        {
                            collection[amount] += collection[value];
                        }
                    }
                }
            }

            return collection[n];

        }

        static void Main(string[] args)
        {
            int amount = 250;
            List<long> value = new List<long>(){41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11};
            var result = getWays(amount, value);
            Console.WriteLine(result);
        }
    }
}
