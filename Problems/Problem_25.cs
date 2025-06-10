using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_25
    {
        public static Dictionary<BigInteger, BigInteger> cache = [];
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int iterator = 50;

            do
            {
                iterator++;
            }
            while (Fibbo(iterator).ToString().Length < 1000);

            stopwatch.Stop();

            Console.WriteLine($"Problem 25 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {iterator}");
        }

        public static BigInteger Fibbo(int num)
        {
            switch (num)
            {
                case 1:
                case 2:
                    return 1;
                default:
                    if (cache.ContainsKey(num))
                    {
                        return cache[num];
                    }
                    cache[num] = Fibbo(num - 1) + Fibbo(num - 2);
                    return cache[num];
            }
        }
    }
}
