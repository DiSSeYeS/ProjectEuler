using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_12
    {
        public static void Solution()
        {

            long totalSum = 0;
            int count = 1;

            for (int i = 1; i < 2000000; i++)
            {
                totalSum += i;
                long tempSum = totalSum;
                int div = 2;

                do
                {
                    if (tempSum % div == 0)
                    {
                        int tempCount = 1;

                        do
                        {
                            tempCount++;
                            tempSum /= div;
                        }
                        while (tempSum % div == 0);

                        count *= tempCount;
                    }

                    div++;
                }
                while (tempSum != 1);

                if (count > 500)
                {
                    Console.WriteLine($"Problem 12 answer: {totalSum}");
                    break;
                }

                count = 1;
            }
        }
    }
}
