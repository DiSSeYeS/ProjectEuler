using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_9
    {
        public static void Solution()
        {
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = i + 1; j <= 1000; j++)
                {
                    for (int k = j + 1; k <= 1000; k++)
                    {
                        if (i + k + j == 1000)
                        {
                            if (i * i + j * j == k * k)
                            {
                                Console.WriteLine($"Problem 9 answer: {i * j * k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
