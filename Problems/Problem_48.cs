using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_48
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BigInteger sum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                sum += Pow(i, i) % 10000000000;
                sum %= 10000000000;
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 48 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }

        public static BigInteger Pow(BigInteger num, int power)
        {
            BigInteger result = num;

            for (int i = 1; i < power; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
