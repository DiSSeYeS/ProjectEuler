using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_36
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 0;

            for (int i = 1; i < 1000000; i++)
            {
                sum += isPalindrome(i.ToString()) && isPalindrome(GetChangedNum(i)) ? i : 0;
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 36 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
        public static string GetChangedNum(int num)
        {
            string changedString = "";

            while (num > 0)
            {
                changedString += num % 2;
                num /= 2;
            }

            return changedString;
        }
        public static bool isPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
