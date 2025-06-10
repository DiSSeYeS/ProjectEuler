using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_78
    {
        public static Dictionary<BigInteger, BigInteger> cache = [];
        public static void Solution()
        {
            Console.WriteLine(P(3));
        }

        public static int P(int n)
        {
            HashSet<HashSet<int>> combinations = new()
            {
                new HashSet<int> { n }
            };

            for (int i = 1; i < n; i++)
            {
                HashSet<int> set = [];
            }

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result += (int)(Factorial(n) / (Factorial(i) * Factorial(n - i)));
            }

            return int.MaxValue;
        }

        public static BigInteger Factorial(BigInteger n)
        {
            return n <= 1 ? 1 : cache.ContainsKey(n) ? cache[n] : cache[n] = n * Factorial(n - 1);
        }
    }
}
