using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_92
    {
        public static Dictionary<int, int> cache = [];
        public static void Solution()
        {
            int count = 0;

            for (int i = 1; i < 10_000_000; i++)
            {
                count += Func(i) == 89 ? 1 : 0;
            }

            Console.WriteLine(count);
        }

        public static int Func(int num)
        {
            Console.Write(num);

            if (num <= 568)
            {
                int firstNum = num;

                HashSet<int> nums = [];
                HashSet<int> cachedNums = [firstNum];
                int sum;

                do
                {
                    //Thread.Sleep();

                    if (cache.ContainsKey(num))
                    {
                        Console.Write(" -> ... -> " + cache[num]);
                        Console.WriteLine();

                        foreach (var item in cachedNums)
                        {
                            cache[item] = cache[num];
                        }

                        return cache[num];
                    }

                    sum = 0;

                    foreach (var n in num.ToString())
                    {
                        sum += int.Parse(n.ToString()) * int.Parse(n.ToString());
                    }

                    Console.Write(" -> " + sum);

                    num = sum;
                    nums.Add(sum);

                    cachedNums.Add(num);
                }
                while (!nums.Contains(89) && !nums.Contains(1));

                Console.WriteLine();

                foreach (var item in cachedNums)
                {
                    cache[item] = num;
                }

                return num;
            }
            else
            {
                int sum = 0;

                foreach (var n in num.ToString())
                {
                    sum += int.Parse(n.ToString()) * int.Parse(n.ToString());
                }

                Console.Write(" -> " + sum + " -> ... -> " + cache[sum]);
                Console.WriteLine();

                return cache[sum];
            }
        }
    }
}
