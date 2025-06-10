using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_22
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

            List<string> names = [];
            BigInteger sum = 0;

            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\rta\\Downloads\\0022_names.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    foreach (var name in line.Split(","))
                    {
                        names.Add(name.Trim('\"'));
                    }

                    line = sr.ReadLine();
                }

                names.Sort();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            for (int i = 0; i < names.Count; i++)
            {
                int letterIndexSum = 0;

                foreach (var letter in names[i])
                {
                    letterIndexSum += alphabet.IndexOf(letter.ToString()) + 1;
                }

                sum += letterIndexSum * (i + 1);
            }

            stopwatch.Stop();

            Console.WriteLine($"Problem 22 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
    }
}
