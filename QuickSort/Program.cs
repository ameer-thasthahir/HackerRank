using System;

namespace QuickSor
{
    class Program
    {
        public static int Sort(int leftStart, int rightEnd, int[] arr, int counter)
        {
            int left = leftStart;
            int right = rightEnd;
            if (leftStart >= rightEnd)
            {
                return counter;
            }
            int median = (leftStart + rightEnd) / 2;

            while (arr[left] < arr[median])
            {
                left++;
            }

            while (arr[right] > arr[median])
            {
                right--;
            }
            if (arr[left] == arr[right])
            {
                return counter;
            }

            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            counter++;


            var rightCounter = Sort(leftStart, median - 1, arr, counter);
           var leftCounter = Sort(median, rightEnd, arr, rightCounter);
            return leftCounter;

        }
        static void Main(string[] args)
        {
            int[] ar = new int[] { 4, 3, 1, 2 };
            int counter = 0;
            var value = Sort(0, ar.Length - 1, ar, counter);
            Console.WriteLine(value);
        }
    }
}
