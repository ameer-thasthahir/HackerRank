using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
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
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        string Number = Console.ReadLine();
        
        int count = Convert.ToInt32(Number);

        var value = Console.ReadLine();
        
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        int[] temp = new int[count];
        
        
        new Solution().MergeSort(arr,0,count-1,temp);
        
        Console.Write("[");
        for(int i=0;i< count;i++)
        {            
            Console.Write(temp[i]);
            if(i < count-1)
            {
                Console.Write(",");
            }
        }
        Console.Write("]");        
        
    }
}