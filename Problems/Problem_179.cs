using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_179
    {
        public static Dictionary<int, List<int>> cache = [];
        public static int lastCount = 2;
        public static void Solution()
        {
            int count = 1;

            for (int i = 3; i + 1 < 10000000; i += 2)
            {
                //count += GetDivisors(GetSimpleDivisors(i)).Count == GetDivisors(GetSimpleDivisors(i + 1)).Count ? 1 : 0;
                //count += GetDivisors(GetSimpleDivisors(i)).Count == GetDivisors(GetSimpleDivisors(i - 1)).Count ? 1 : 0;

                count += IsCountOfDivisorsEquals(i);

                //Console.WriteLine(lastCount + " " + i);

                count += IsCountOfDivisorsEquals(i + 1);

            }

            Console.WriteLine(count);
        }

        public static int FindNextDiv(int num, int div)
        {
            while (num % div > 0 & div < num)
            {
                div++;
                //Console.WriteLine(div);
            }

            return div;
        }

        public static int IsCountOfDivisorsEquals(int num2)
        {

            int count2 = 2;
            int tempSum2 = num2;
            int div2 = FindNextDiv(tempSum2, 2);
 
            do
            {
                bool takenFromCache = false;
                int templength2 = 1;

                int lastCacheElem = tempSum2;

                do
                {
                    if (cache.ContainsKey(tempSum2))
                    {
                        List<int> cacheElems = cache[tempSum2];

                        templength2 += cacheElems[0] + 1;
                        tempSum2 = cacheElems[1];
                        div2 = cacheElems[2];
                        count2 *= templength2;
                        takenFromCache = true;
                        break;
                    }

                    templength2++;
                    tempSum2 /= div2;
                }
                while (tempSum2 % div2 == 0);

                if (!takenFromCache)
                {
                    count2 *= templength2;
                    div2 = FindNextDiv(tempSum2, div2);
                    cache[lastCacheElem] = new() { templength2 - 2, tempSum2, div2 };
                }
                    
                

                

            }
            while (tempSum2 != 1);

            if (lastCount != count2)
            {
                lastCount = count2;
                return 0;
            }

            lastCount = count2;
            return 1;
        }
        public static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
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
