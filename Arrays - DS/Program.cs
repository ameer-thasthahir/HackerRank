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

    // Complete the reverseArray function below.
    static int[] reverseArray(int[] a)
    {
        int[] outputValue = new int[a.Length];
        int forward = 0;
        for (int i = a.Length-1; i >= 0; i--)
        {
            
            outputValue[forward]=a[i];
            forward++;
        }
        return outputValue;
    }

    static void Main(string[] args)
    {       

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);

        Console.Read();
    }
}
