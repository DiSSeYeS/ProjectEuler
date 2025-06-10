using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_23
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> abundants = [];
            HashSet<int> abundantsSums = [];
            int sum = 0;
            
            for (int i = 12; i <= 28123; i++)
            {
                if (GetDivisors(GetSimpleDivisors(i)).Sum() - i > i)
                {
                    abundants.Add(i);
                }
            }

            for (int i = 0; i < abundants.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    abundantsSums.Add(abundants[i] + abundants[j]);
                }
            }

            for (int i = 0; i <= 28123; i++)
            {
                sum += !abundantsSums.Contains(i) ? i : 0;
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 23 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
        public static List<List<int>> GetSimpleDivisors(int num)
        {
            List<List<int>> result = [];
            int div = 2;

            do
            {
                if (num % div == 0)
                {
                    int templength = 1;
                    List<int> tempArr = new List<int> { 1 };

                    do
                    {
                        tempArr.Add((int)Math.Pow(div, templength));
                        templength++;
                        num /= div;
                    }
                    while (num % div == 0);

                    result.Add(tempArr);
                }

                div++;
            }
            while (num != 1);

            return result;
        }
        public static List<int> GetDivisors(List<List<int>> arr)
        {
            List<int> mergedArray = [];

            if (arr.Count < 2)
            {
                return arr.Count() == 0 ? [] : arr.First();  
            }

            foreach (var num1 in arr[0])
            {
                foreach (var num2 in arr[1])
                {
                    mergedArray.Add(num1 * num2);
                }
            }

            if (1 < arr.Count - 1)
            {
                List<List<int>> nextArray = [];
                nextArray.Add(mergedArray);

                for (int i = 2; i < arr.Count; i++)
                {
                    nextArray.Add(arr[i]);
                }

                return GetDivisors(nextArray);
            }

            return mergedArray;
        }
    }
}
