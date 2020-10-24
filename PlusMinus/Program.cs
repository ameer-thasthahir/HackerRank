using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        float plus = 0;
        float minus = 0;
        float zero = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                plus = plus + 1;
            }
            if (arr[i] == 0)
            {
                zero = zero + 1;
            }
            if (arr[i] < 0)
            {
                minus = minus + 1;
            }           
        }
        Console.WriteLine(plus / arr.Length);
        Console.WriteLine(minus / arr.Length);
        Console.WriteLine(zero / arr.Length);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
        Console.Read();
    }
}
