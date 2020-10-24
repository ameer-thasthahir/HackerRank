using System;

namespace BubbleSortAlogorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            PubbleSort(ar);
            Console.Read();
        }
        static void PubbleSort(int[] arr)
        {
            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }            
            for (int k = 0; k < arr.Length; k++)
            {
                if (k != (arr.Length - 1))
                {
                    minSum = minSum + arr[k];
                }
                int l = (arr.Length-1) - k;
                if(l!=0)
                {
                    maxSum = maxSum + arr[l];
                }
                //Console.WriteLine(arr[k]);
            }
            
            Console.WriteLine(Math.Abs(minSum)+" "+Math.Abs(maxSum));
           

        }
    }
}
