using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_52
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            bool flag = true;

            for (int i = 1; i < 100000000; i++)
            {
                HashSet<char> set = [];

                char[] x1 = i.ToString().ToCharArray();
                char[] x2 = (i * 2).ToString().ToCharArray();
                char[] x3 = (i * 3).ToString().ToCharArray();
                char[] x4 = (i * 4).ToString().ToCharArray();
                char[] x5 = (i * 5).ToString().ToCharArray();
                char[] x6 = (i * 6).ToString().ToCharArray();

                foreach (var num in x1)
                {
                    set.Add(num);
                }

                flag = 
                    !(
                    CheckElements(set, x2) && 
                    CheckElements(set, x3) &&
                    CheckElements(set, x4) && 
                    CheckElements(set, x5) && 
                    CheckElements(set, x6) 
                    );

                if (!flag)
                {
                    stopwatch.Stop();

                    Console.WriteLine($"Problem 52 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {i}");
                    break;
                }
            }
        }

        public static bool CheckElements(HashSet<char> set, char[] arr)
        {
            foreach (var num in arr)
            {
                if (!set.Contains(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
