using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_29
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            HashSet<BigInteger> set = [];

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    set.Add((BigInteger)Math.Pow(i, j));
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 29 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {set.Count}");
        }
    }
}
