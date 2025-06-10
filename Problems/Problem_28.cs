using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem_28
    {
        public static List<List<int>> matrix = [];
        public static int index_x = 1000, index_y = 1000;
        public static void Solution()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int num = 1001*1001;
            BigInteger sum = 0;

            for (int i = 0; i < 1001; i++)
            {
                List<int> temp = [];

                for (int j = 0; j < 1001; j++)
                {
                    temp.Add(0);
                }

                matrix.Add(temp);
            }

            do
            {
                num = Left(num);
                num = Down(num);
                num = Right(num);
                num = Up(num);
            }
            while (num > 1);

            for (int i = 0; i < 500; i++)
            {
                sum += matrix[i][i];
                sum += matrix[1000 - i][1000 - i];
                sum += matrix[i][1000 - i];
                sum += matrix[1000 - i][i];
            }
            sum++;

            stopwatch.Stop();

            Console.WriteLine($"Problem 28 solved in {stopwatch.ElapsedMilliseconds} ms. Answer: {sum}");
        }
        public static int Up(int num)
        {
            while (index_y - 1 >= 0 && matrix[index_y - 1][index_x] == 0)
            {
                matrix[index_y][index_x] = num;
                index_y--;
                num--;
            }

            return num;
        } 
        public static int Down(int num)
        {
            while (index_y + 1 < 1001 && matrix[index_y + 1][index_x] == 0)
            {
                matrix[index_y][index_x] = num;
                index_y++;
                num--;
            }

            return num;
        }
        public static int Left(int num)
        {
            while (index_x - 1 >= 0 && matrix[index_y][index_x - 1] == 0)
            {
                matrix[index_y][index_x] = num;
                index_x--;
                num--;
            } 

            return num;
        }
        public static int Right(int num)
        {
            while (index_x + 1 < 1001 && matrix[index_y][index_x + 1] == 0)
            {
                matrix[index_y][index_x] = num;
                index_x++;
                num--;
            }

            return num;
        }
    }
}
