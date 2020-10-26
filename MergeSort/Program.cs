using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        public void MergeSort(List<int> arry, int leftStart, int rightEnd, int[] temp)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }

            int middle = (leftStart + rightEnd) / 2;

            MergeSort(arry, leftStart, middle, temp);

            MergeSort(arry, middle + 1, rightEnd, temp);

            MergeHalves(arry, leftStart, rightEnd, temp);

        }

        public void MergeHalves(List<int> arry, int leftStart, int rightEnd, int[] temp)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            int size = (rightEnd - leftStart) + 1;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (arry[left] < arry[right])
                {
                    temp[index] = arry[left];
                    left++;
                }
                else
                {
                    temp[index] = arry[right];
                    right++;

                }

                index++;
            }

            while (left <= leftEnd)
            {
                temp[index++] = arry[left++];
            }

            while (right <= rightEnd)
            {
                temp[index++] = arry[right++];
            }

            for (int i = 0; i < size; i++)
            {
                arry[rightEnd] = temp[rightEnd];
                rightEnd--;
            }
        }

        static void Main(string[] args)
        {
            List<int> arry = new List<int>() { 94,39,31,51,30,100,26,85,44,13,69,88,1,59,95,45,65,47,2,83,67,68,46,5,59,82,17,85,55,61,4,77,44,24,25,82,48,87,36,21,100,43,78,71,53,79,98,58,49,63,72,39,7,70,89,96,50,81,79,56,13,29,45,21,98,60,61,13,75,100,97,22,94,6,35,65,84,36,69,99,75,88,34,31,36,36,32,32,92,71,100,62,89,70,12,20,28,8,96,99};

            int[] temp = new int[arry.Count];

            new Program().MergeSort(arry, 0, arry.Count - 1, temp);

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

                                
        }
    }
}
