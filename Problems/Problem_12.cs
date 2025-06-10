using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_12
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long totalSum = 0;
            int length = 1;

            for (int i = 1; i < 2000000; i++)
            {
                totalSum += i;
                long tempSum = totalSum;
                int div = 2;

                do
                {
                    if (tempSum % div == 0)
                    {
                        int templength = 1;

                        do
                        {
                            templength++;
                            tempSum /= div;
                        }
                        while (tempSum % div == 0);

                        length *= templength;
                    }

                    div++;
                }
                while (tempSum != 1);

                if (length > 500)
                {
                    stopwatch.Stop();

                    Console.WriteLine($"Problem 12 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {totalSum}");
                    break;
                }

                length = 1;
            }
        }
    }
}
