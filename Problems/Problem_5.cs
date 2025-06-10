using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_5
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool flag = true;

            for (int i = 20 * 19 * 17; i <= 20000; i += 20)
            {
                int result;

                for (int j = 20; j <= 20000; j++)
                {
                    flag = true;
                    for (int k = 2; k <= 20; k++)
                    {
                        if (i * j % k != 0 && i * j > 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        result = i * j;
                        Console.WriteLine($"Problem 5 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {result}");
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }
        }
    }
}
