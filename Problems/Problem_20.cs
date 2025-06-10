using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_20
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 0;
            BigInteger factorial = Factorial(100);

            do
            {
                factorial /= 10;
                sum += (int)(factorial % 10);
            }
            while (factorial > 0);

            stopwatch.Stop();

            Console.WriteLine($"Problem 20 solved in: {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }

        public static BigInteger Factorial(BigInteger num)
        {
            return num == 1 ? 1 : num * Factorial(num - 1);
        }
    }
}
