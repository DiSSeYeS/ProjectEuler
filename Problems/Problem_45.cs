using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_45
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            double triangle;
            int n = 286;

            do
            {
                triangle = Problem_42.t(n);
                n++;
            }
            while (!(IsPentagonal(triangle) && IsHexagonal(triangle)));

            stopwatch.Stop();

            Console.WriteLine($"Problem 45 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {triangle}");
        }
        public static bool IsPentagonal(double num)
        {
            double result = (Math.Sqrt(24 * (double)num + 1) + 1d) / 6d;
            return result == (int)result;
        }
        public static bool IsHexagonal(double num)
        {
            double result = (Math.Sqrt(8 * (double)num + 1) + 1d) / 4d;
            return result == (int)result;
        }
    }
}
