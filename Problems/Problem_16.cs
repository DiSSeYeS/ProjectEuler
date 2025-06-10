using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_16
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BigInteger exponented = 2;

            for (int i = 1; i < 1000; i++)
            {
                exponented *= 2;
            }

            string expString = exponented.ToString();
            int result = 0;

            foreach (var num in expString)
            {
                result += int.Parse(num.ToString());
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 16 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {result}"); 
        }
    }
}
