using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_10
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long sum = 2;

            for (int i = 3; i < 2000000; i += 2)
            {
                bool flag = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    sum += i;
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 10 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
    }
}
