using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_2
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 2;
            List<int> fibbo = new List<int>() { 1, 2 };

            for (int i = 0; i < 50; i++)
            {
                int newFibbo = fibbo[i] + fibbo[i + 1];

                if (newFibbo < 4000000)
                {
                    fibbo.Add(newFibbo);

                    if (newFibbo % 2 == 0)
                    {
                        sum += newFibbo;
                    }

                }
                else
                {
                    break;
                }

            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 2 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
    }
}
