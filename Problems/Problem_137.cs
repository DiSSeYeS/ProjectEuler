using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_137
    {
        public static Dictionary<int, BigInteger> cache = [];
        public static void Solution()
        {
            for (int i = 1; i < 1000000; i++)
            {
                Console.WriteLine(Fibbo(i));
            }
        }
        
        public static BigInteger Fibbo(int num)
        {
            switch (num)
            {
                case 1:
                case 2:
                    return cache[num] = 1;
                default:
                    return cache.ContainsKey(num) ? cache[num] : cache[num] = Fibbo(num - 1) + Fibbo(num - 2);
            }
        }
    }
}
