using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_7
    {
        public static void Solution()
        {
            List<int> primes = new List<int>() { 2 };
            int num = 3;

            while (primes.Count < 10001)
            {
                bool flag = true;
                int div_num = 2;
                while (div_num < Math.Sqrt(num)+1)
                {
                    if (num % div_num == 0)
                    {
                        flag = false;
                        break;
                    }
                    div_num++;

                }

                if (flag)
                {
                    primes.Add(num);
                }

                num += 2;
            }

            Console.WriteLine($"Problem 7 answer: {primes.Last()}");
        }
    }
}
