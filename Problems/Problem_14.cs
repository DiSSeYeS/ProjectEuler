using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_14
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Dictionary<long, long> cache = [];
            long result = 0;

            long collatzSequence(long num)
            {
                long NUM = num;
                long length = 1;
                while (num > 1)
                {

                    if (cache.ContainsKey(num))
                    {
                        length += cache[num];
                        break;
                    }
                    else
                    {
                        switch (num % 2 == 0)
                        {
                            case true:
                                length++;
                                num = num / 2;
                                break;
                            case false:
                                length += 2;
                                num = (num * 3 + 1) / 2;
                                break;
                        }

                    }
                }

                if (!cache.ContainsKey(NUM))
                {
                    cache[NUM] = length;
                }
                return length;
            }

            for (int i = 1000000; i > 0; i--)
            {
                if (collatzSequence(i) > collatzSequence(result))
                {
                    result = i;
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 14 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {result}");
        }
    }
}
