using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class SalesMatch
    {
        // Complete the aVeryBigSum function below.
        public static int SockMerchant(int n, int[] ar)
        {
            var colorsList = new HashSet<int>();
            int pair = 0;

            for(int i =0;i< n; i++)
            {
                if (!(colorsList.Contains(ar[i])))
                {
                    colorsList.Add(ar[i]);
                }
                else
                {
                    pair++;
                    colorsList.Remove(ar[i]);                    
                }
            }

            return pair;
        }


        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}


