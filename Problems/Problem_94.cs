using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_94
    {
        public static void Solution()
        {
            int limit = 333_333_333;
            int[] arr = { -1, 1 };
            HashSet<BigInteger> array = new();
            BigInteger result = 0;

            for (float i = 2; i <= limit; i++)
            {
                foreach (var num in arr)
                {
                    float c = i + num;

                    if (IsValidTriangle(i, c))
                    {
                        //Console.WriteLine(i + " " + c);
                        result += (BigInteger)P(i, c);

                       // Console.WriteLine(i + " " + c + " " + S(i, c) + " " + P(i, c));
                    }
                }
            }

            foreach (var item in array)
            {
                result += item;
            }

            Console.WriteLine(result);
        }

        public static float P(float a, float b) => a * 2 + b;

        public static float S(float a, float b)
        {
            float p = P(a, b) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - a) * (p - b));
        }

        public static bool IsValidTriangle(float a, float b) => S(a, b) % 1 == 0;
    }
}
