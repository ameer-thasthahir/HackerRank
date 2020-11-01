using System;

namespace NewYearChaos
{


    class Program
    {
        static void minimumBribes(int[] a)
        {

            int counter = 0;

            int size = a.Length;

            for (int i = size - 1; i > 0; i--)
            {
                if (a[i] == i + 1)
                {
                    continue;
                }

                if (a[i - 1] == i + 1)
                {
                    counter = counter + 1;
                    var temp = a[i];
                    a[i] = a[i - 1];
                    a[i-1] =temp;
                    continue;
                }

                else if (a[i - 2] == i + 1)
                {
                    counter = counter + 2;
                    var temp = a[i-1];
                    a[i-1] =a[i-2];
                    a[i-2] = temp;

                    temp = a[i];
                    a[i] = a[i-1];
                    a[i-1] = temp;
                    
                    continue;
                }

                else
                {
                    counter = 0;
                    Console.WriteLine("Too chaotic");
                    break;
                }
            }

            if (counter != 0)
            {
                Console.WriteLine(counter);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int[] array = new int[]{2, 1, 5, 3, 4}; -> 3
            // int[] array = new int[]{2 ,5, 1, 3, 4}; -> Too choatic
            // int[] array = new int[]{5, 1, 2, 3, 7, 8, 6, 4}; -> Too choatic
            // int[] array = new int[] { 1, 2, 5, 3, 7, 8,  6, 4 };
            int[] array = new int[] { 1, 2, 5, 3, 4, 7, 8, 6 };
            minimumBribes(array);
        }
    }
}
