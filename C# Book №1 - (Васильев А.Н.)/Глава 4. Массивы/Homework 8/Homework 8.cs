/*Напишите программу, в которой создается двумерный целочисленный
массив. Он заполняется случайными числами. Затем в этом массиве
строки и столбцы меняются местами: первая строка становится первым
столбцом, вторая строка становится вторым столбцом и так далее. Например,
если исходный массив состоял из 3 строк и 5 столбцов, то в итоге
получаем массив из 5 строк и 3 столбцов.*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] nums = new int[rnd.Next(2, 6), rnd.Next(2, 6)];

            for (int y = 0; y < nums.GetLength(0); y++)
            {
                for (int x = 0; x < nums.GetLength(1); x++)
                {
                    nums[y, x] = rnd.Next(1, 101);
                }
            }

            for (int y = 0; y < nums.GetLength(0); y++)
            {
                for (int x = 0; x < nums.GetLength(1); x++)
                {
                    Console.Write(nums[y, x] + "\t");
                }
                Console.WriteLine();
            }

            int[,] tmp = new int[nums.GetLength(1), nums.GetLength(0)];

            for (int y = 0; y < tmp.GetLength(0); y++)
            {
                for (int x = 0; x < tmp.GetLength(1); x++)
                {
                    tmp[y, x] = nums[x, y];
                }
            }

            nums = tmp;

            Console.WriteLine();
            for (int y = 0; y < nums.GetLength(0); y++)
            {
                for (int x = 0; x < nums.GetLength(1); x++)
                {
                    Console.Write(nums[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
