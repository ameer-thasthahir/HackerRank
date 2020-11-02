using System;

namespace ArrayManipulation
{
    class Program
    {
        static long arrayManipulation(int n, int[,] queries)
        {
                long maximum = int.MinValue;
                int length = queries.GetLength(0);
                long[] f  = new long[n];
                for(int i = 0;i<length;i++)
                {
                    for(int j=queries[i,0];j<=queries[i,1];j++)
                    {
                        f[j] += queries[i,2];
                    }
                }

                for(int i = 0;i<f.Length;i++)
                {
                    if(maximum < f[i])
                    {
                        maximum = f[i];
                    }
                }

                return maximum;

        }

        static void Main(string[] args)
        {
            int[,] multiarray = new int[3,3]
            {
                {1,2,100},
                {2,5,100},
                {3,4,100}
            };
            var result = arrayManipulation(10, multiarray);
            Console.WriteLine(result);
        }
    }
}
