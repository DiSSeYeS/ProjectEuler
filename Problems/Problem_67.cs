using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_67
    {
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int[]> arrayList = new List<int[]>();

            String line;
            int count = 1;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\rta\\Downloads\\0067_triangle.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] numbers = Array.ConvertAll(parts, int.Parse);

                    arrayList.Add(numbers);

                    line = sr.ReadLine();
                    count++;
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            for (int i = 1; i < arrayList.Count; i++)
            {

                for (int j = 0; j < arrayList[i].Length; j++)
                {
                    if (j == 0)
                    {
                        arrayList[i][j] += arrayList[i - 1][j];
                    }
                    else if (j == arrayList[i].Length - 1)
                    {
                        arrayList[i][j] += arrayList[i - 1][j - 1];
                    }
                    else
                    {
                        arrayList[i][j] += (arrayList[i - 1][j - 1] > arrayList[i - 1][j]) switch
                        {
                            true => arrayList[i - 1][j - 1],
                            false => arrayList[i - 1][j],
                        };
                    }

                    // Console.Write(arrayList[i][j] + " ");
                }

                // Console.WriteLine();
            }

            Console.WriteLine($"Problem 67 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {arrayList[^1].Max()}");
        }
    }
}