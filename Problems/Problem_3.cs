using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_3
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> primes = new List<int>();

            for (int i = 2; i < 1000; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    primes.Add(i);
                }
            }
            primes.Reverse();

            foreach (var item in primes)
            {
                if (600851475143 % item == 0)
                {
                    Console.WriteLine($"Problem 3 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {item}");
                    break;
                }
            }
        }
    }
}
