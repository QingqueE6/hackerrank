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
    public static string timeConversion(string s)
    {
        bool IsAm = (s.Contains("AM")) ? true : false;
        s = s.Remove(8);
        string[] HMS = s.Split(':');
        int Hours = int.Parse(HMS[0]);
        Hours = IsAm ? (Hours == 12 ? 0 : Hours) : (Hours == 12 ? Hours : Hours + 12);
        
        string MilitaryTime = $"{Hours:D2}:{HMS[1]}:{HMS[2]}";
        return MilitaryTime;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
