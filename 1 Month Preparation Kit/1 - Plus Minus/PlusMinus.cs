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
    // This part here is what I wrote, the main method is just a way for hackerrank to register the inputs
    public static void plusMinus(List<int> arr)
    {
        int Total = arr.Count;
        int Positive = 0;
        int Negative = 0;
        int Zero = 0;

        foreach(int number in arr){
            if(number > 0)Positive++;
            else if(number < 0) Negative++;
            else Zero++;
        };
            decimal DecimalPositive = (decimal)Positive / Total;
            decimal DecimalNegative = (decimal)Negative / Total;
            decimal DecimalZero = (decimal)Zero / Total;
            Console.WriteLine(DecimalPositive);
            Console.WriteLine(DecimalNegative);
            Console.WriteLine(DecimalZero);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
