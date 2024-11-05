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

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        long arrMaxNumber = arr[0];
        long arrMinNumber = arr[0];
        long arrTotal = arr[0];

        for(int i = 1; i < 5; i++){
            if(arr[i] < arrMinNumber) arrMinNumber = arr[i];
            if(arr[i] > arrMaxNumber) arrMaxNumber = arr[i];
            arrTotal += arr[i];
        }
        long MinSum = arrTotal - arrMaxNumber;
        long MaxSum = arrTotal - arrMinNumber;
        Console.WriteLine(MinSum + " " + MaxSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
