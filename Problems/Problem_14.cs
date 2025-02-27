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
            Dictionary<long, long> cache = new Dictionary<long, long>();
            long result = 0;

            long collatzSequence(long num)
            {
                long NUM = num;
                long count = 1;
                while (num > 1)
                {

                    if (cache.ContainsKey(num))
                    {
                        count += cache[num];
                        break;
                    }
                    else
                    {
                        switch (num % 2 == 0)
                        {
                            case true:
                                count++;
                                num = num / 2;
                                break;
                            case false:
                                count += 2;
                                num = (num * 3 + 1) / 2;
                                break;
                        }

                    }
                }

                if (!cache.ContainsKey(NUM))
                {
                    cache[NUM] = count;
                }
                return count;
            }

            for (int i = 1000000; i > 0; i--)
            {
                if (collatzSequence(i) > collatzSequence(result))
                {
                    result = i;
                }
            }

            Console.WriteLine($"Problem 14 answer: {result}");
        }
    }
}
