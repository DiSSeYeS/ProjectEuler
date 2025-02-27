using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_4
    {
        public static void Solution()
        {
            int result = 0;

            bool isPalindrome(string word)
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

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int mul = i * j;

                    if (isPalindrome(mul.ToString()) & mul > result)
                    {
                        result = mul;
                    }
                }
            }

            Console.WriteLine($"Problem 4 answer: { result}");
        }
    }
}
