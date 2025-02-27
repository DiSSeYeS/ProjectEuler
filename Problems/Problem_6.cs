using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_6
    {
        public static void Solution()
        {
            int sum_square = 0, square_sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum_square += i * i;
                square_sum += i;
            }

            square_sum *= square_sum;

            Console.WriteLine($"Problem 6 answer: {square_sum-sum_square}");
        }
    }
}
