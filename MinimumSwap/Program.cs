using System;

namespace MinimumSwap
{
    class Program
    {
        public static int minimumSwaps(int[] arr)
        {
            int count = 0;
            int size = arr.Length;
            int[] visitedPlace = new int[size];
            for(int i = 0; i<visitedPlace.Length;i++)
            {
                visitedPlace[i] = -1;
            }
            for(int i=0;i<size;i++)
            {
                int j = i;
                if(arr[i] == i+1 || visitedPlace[i] == 0)
                {
                    continue;
                }
                visitedPlace[j] = 0;
                while(arr[arr[j]-1] != arr[arr[j]-1] + 1 && arr[arr[j]-1] != arr[i])
                {
                   
                    count++;
                    j=arr[j]-1;
                    visitedPlace[j] = 0;
                    
                }                
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr= new int[]{2, 3, 4, 1, 5};
           var result = minimumSwaps(arr);
           Console.WriteLine(result);           
        }
    }

}
