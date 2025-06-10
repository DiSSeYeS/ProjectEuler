using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_15
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BigInteger result = factorial(40) / (factorial(20) * factorial(20));

            stopwatch.Stop();

            Console.WriteLine($"Problem 15 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {result}");
        }

        public static BigInteger factorial(BigInteger num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * factorial(num - 1);
        }
    }
}
