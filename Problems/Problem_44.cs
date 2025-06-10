using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_44
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            bool flag = true;
            List<BigInteger> pentagons = [];

            for (int i = 1; i < 3000 && flag; i++)
            {
                BigInteger pentagon = P(i);
                pentagons.Add(pentagon);

                for (int j = 0; j < pentagons.Count - 1; j++)
                {
                    if (IsPentagonal(pentagon - pentagons[j]) && IsPentagonal(pentagon + pentagons[j]))
                    {
                        stopwatch.Stop();

                        Console.WriteLine($"Problem 44 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {pentagon - pentagons[j]}");
                        flag = false;
                        break;
                    }
                }
            }
        }
        public static bool IsPentagonal(BigInteger num)
        {
            double result = (Math.Sqrt(24 * (double)num + 1) + 1d) / 6d;
            return result == (int)result; 
        }
        public static BigInteger P(int num)
        {
            return num * ((BigInteger)(3 * num) - 1) / 2;
        }
    }
}
