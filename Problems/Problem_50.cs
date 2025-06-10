using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_50
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            BigInteger biggestPrime = 1;
            
            for (int i = 1; i < 100; i++)
            {
                BigInteger sum = 0;

                if (!IsPrime(i))
                {
                    continue;
                }

                for (int j = i; j < 4_000 && sum < 1_000_000; j++)
                {
                    biggestPrime = IsPrime(sum) & sum > biggestPrime ? sum : biggestPrime;

                    sum += IsPrime(j) ? j : 0;                    
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 50 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {biggestPrime}");
        }

        public static bool IsPrime(BigInteger num)
        {
            for (int i = 2; i <= Math.Sqrt((ulong)num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
