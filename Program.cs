using Euler.Problems;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Runtime.InteropServices;

public class Program()
{
    public static void Main()
    {
        //Problem_78.Solution();
        //Problem_179.Solution();
        //Problem_137.Solution();
        Problem_94.Solution();
        // CallFastSolutions();
    }

    public static void CallEverySolution()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        
        Problem_1.Soultion();
        Problem_2.Solution();
        Problem_3.Solution();
        Problem_4.Solution();
        Problem_5.Solution();
        Problem_6.Solution();
        Problem_7.Solution();
        Problem_8.Solution(); // Решить проще
        Problem_9.Solution(); // Решить проще
        Problem_10.Solution();
        Problem_11.Solution();
        Problem_12.Solution();
        Problem_13.Solution();
        Problem_14.Solution();
        Problem_15.Solution();
        Problem_16.Solution();
        Problem_18.Solution();
        Problem_20.Solution();
        Problem_21.Solution();
        Problem_22.Solution();
        Problem_23.Solution();
        Problem_25.Solution();
        Problem_28.Solution();
        Problem_29.Solution();
        Problem_34.Solution();
        Problem_36.Solution();
        Problem_42.Solution();
        Problem_44.Solution();
        Problem_45.Solution();
        Problem_48.Solution();
        Problem_50.Solution();
        Problem_52.Solution();
        Problem_60.Solution();
        Problem_67.Solution();
        Problem_92.Solution();

        stopwatch.Stop();
        
        Console.WriteLine($"Solve every problem in {stopwatch.ElapsedMilliseconds} ms.");
    }

    public static void CallFastSolutions()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        
        Problem_1.Soultion();
        Problem_2.Solution();
        Problem_3.Solution();
        Problem_4.Solution();
        Problem_5.Solution();
        Problem_6.Solution();
        Problem_7.Solution();
        Problem_8.Solution(); // Решить проще
        Problem_9.Solution(); // Решить проще
        Problem_10.Solution();
        Problem_11.Solution();
        Problem_12.Solution();
        Problem_13.Solution();
        Problem_14.Solution();
        Problem_15.Solution();
        Problem_16.Solution();
        Problem_18.Solution();
        Problem_20.Solution();
        Problem_21.Solution();
        Problem_22.Solution();
        Problem_23.Solution();
        Problem_25.Solution();
        Problem_28.Solution();
        Problem_29.Solution();
        Problem_34.Solution();
        Problem_36.Solution();
        Problem_42.Solution();
        Problem_44.Solution();
        Problem_45.Solution();
        Problem_48.Solution();
        Problem_50.Solution();
        Problem_52.Solution();
        Problem_67.Solution();
        
        stopwatch.Stop();
        
        Console.WriteLine($"Execute fast solutions in {stopwatch.ElapsedMilliseconds} ms.");
    }

    public static void CallSlowSolutions()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        Problem_60.Solution();

        stopwatch.Stop();

        Console.WriteLine($"Execute slow solutions in {stopwatch.ElapsedMilliseconds} ms.");
    }
}