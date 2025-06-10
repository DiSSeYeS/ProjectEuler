using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Euler.Problems
{
    class Problem_60
    {
        public static Func<BigInteger, bool> IsPrime = Problem_50.IsPrime;
        public static Dictionary<int, List<int>> cache = [];
        public static void Solution()
        {
            int iterator = 121;
            List<int> primes = [];

            for (int i = 3; i  < 1000000; i += 2)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            do
            {
                int first = primes[iterator];

                for (int i = 120; i < iterator; i++)
                {
                    int second = primes[i];

                    if (cache.ContainsKey(first) && cache[first].Contains(second))
                    {
                        continue;
                    }

                    for (int j = 27; j < i; j++)
                    {
                        int third = primes[j];

                        if (cache.ContainsKey(second) && cache[second].Contains(third) ||
                           (cache.ContainsKey(first) && cache[first].Contains(third)))
                        {
                            continue;
                        }

                        for (int k = 2; k < j; k++)
                        {
                            int fourth = primes[k];

                            if ((cache.ContainsKey(third)  && cache[third].Contains(fourth))  ||
                                (cache.ContainsKey(second) && cache[second].Contains(fourth)) ||
                                (cache.ContainsKey(first)  && cache[first].Contains(fourth)))
                            {
                                continue;
                            }
       
                            for (int m = 0; m < k; m++)
                            {
                                int fifth = primes[m];

                                if ((cache.ContainsKey(fourth) && cache[fourth].Contains(fifth)) ||
                                    (cache.ContainsKey(third)  && cache[third].Contains(fifth))  ||
                                    (cache.ContainsKey(second) && cache[second].Contains(fifth)) ||
                                    (cache.ContainsKey(first)  && cache[first].Contains(fifth)))
                                {
                                    continue;
                                }

                                List<int> elements = [ first, second, third, fourth, fifth ];

                                if (ConcatEveryElements(elements))
                                {
                                    Console.WriteLine(elements.Sum());
                                    Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                }

                                // Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                            }
                        }
                    }
                }

                iterator++;
            }
            while (true);

        }

        public static bool IsEveryElementPrime(IEnumerable<int> arr)
        {
            foreach (var num in arr)
            {
                if (!IsPrime(num))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ConcatEveryElements(List<int> arr)
        {
            HashSet<int> resultArray = [];

            foreach (var num1 in arr)
            {
                if (!cache.ContainsKey(num1))
                {
                    cache[num1] = [];
                }

                foreach (var num2 in arr)
                {
                    if (num1 != num2)
                    {
                        int element = int.Parse(num1.ToString() + num2.ToString());

                        if (!IsPrime(element))
                        {
                            cache[Math.Max(num1, num2)].Add(Math.Min(num1, num2));

                            return false;
                        }

                        resultArray.Add(element);
                    }
                }
            }

            return true;
        }
    }
}
