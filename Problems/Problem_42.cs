using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_42
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<string> alphabet = new List<string>
            {
                "A", "B", "C", "D", "E", "F", "G",
                "H", "I", "J", "K", "L", "M", "N",
                "O", "P", "Q", "R", "S", "T", "U",
                "V", "W", "X", "Y", "Z",
            };

            List<string> words = [];
            BigInteger sum = 0;

            string line;
            int count = 0;
            List<double> triangles = [];

            for (int i = 1; i < 100; i++)
            {
                triangles.Add(t(i));
            }

            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\rta\\Downloads\\0042_words.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    foreach (var name in line.Split(","))
                    {
                        words.Add(name.Trim('\"'));
                    }

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            for (int i = 0; i < words.Count; i++)
            {
                int letterIndexSum = 0;

                foreach (var letter in words[i])
                {
                    letterIndexSum += alphabet.IndexOf(letter.ToString()) + 1;
                }

                if (triangles.Contains(letterIndexSum))
                {
                    count++;
                }

            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 42 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {count}");
        }
        public static double t(int num)
        {
            return 0.5 * num * (num + 1);
        }
    }
}
