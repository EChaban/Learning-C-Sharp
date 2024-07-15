/*Напишите программу со статическим методом, аргументом которому
передается двумерный целочисленный массив. У метода, кроме аргумента-
массива, есть два неинициализированных аргумента. Результатом метод
возвращает значение наибольшего элемента в массиве. Неинициализированным
аргументам присваиваются значения индексов этого элемента.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static int MaxNum(int[,] nums, out int x, out int y)
        {
            int maxNum = 0;
            x = 0; y = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] > maxNum)
                    {
                        maxNum = nums[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return maxNum;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x, y;
            int[,] nums = new int[rnd.Next(5, 11), rnd.Next(5, 11)];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rnd.Next(0, 101);
                }
            }

            Console.WriteLine("Массив: ");

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"Наибольший элемент в массиве: {MaxNum(nums, out x, out y)}");
            Console.WriteLine($"Индексы элемента: x = {x}, y = {y}");

            Console.WriteLine();
        }
    }
}
