using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_34
    {
        public static Dictionary<int, BigInteger> cache = [];
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BigInteger sum = 0;

            for (int i = 3; i < 100000; i++)
            {
                int num = i;
                BigInteger factorialDigitsSum = 0;

                do
                {
                    factorialDigitsSum += Factorial(num % 10);
                    num /= 10;
                }
                while (num > 0);

                sum += i == factorialDigitsSum ? i : 0;
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 34 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }

        public static BigInteger Factorial(int num)
        {
           return new List<int>() { 1, 0 }.Contains(num) ? 1 : cache.TryGetValue(num, out BigInteger value) ? value : cache[num] = num * Factorial(num - 1);
        }
    }
}
