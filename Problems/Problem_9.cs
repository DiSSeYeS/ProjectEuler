using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_9
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 1000; i++)
            {
                for (int j = i + 1; j <= 1000; j++)
                {
                    for (int k = j + 1; k <= 1000; k++)
                    {
                        if (i + k + j == 1000)
                        {
                            if (Functions.Square(i) + Functions.Square(j) == Functions.Square(k))
                            {
                                Console.WriteLine($"Problem 9 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {i * j * k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
