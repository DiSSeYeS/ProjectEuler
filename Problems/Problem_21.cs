using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_21
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            HashSet<int> arr = [];
            
            for (int i = 1; i < 10000; i++)
            {
                if (D(i) != i && D(D(i)) == i)
                {
                    arr.Add(D(i) + i);
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 21 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {arr.Sum()}");
        }
        public static int D(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                sum += num % i == 0 ? i : 0;
            }

            return sum;
        }
    }
}
