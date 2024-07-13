/*Напишите программу со статическим методом, аргументом которому
передается целочисленный массив, а результатом возвращается среднее
значение для элементов массива (сумма значений элементов, деленная
на количество элементов в массиве).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static int AverageNumArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) sum += nums[i];
            return sum / nums.Length;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[rnd.Next(5,11)];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 101);
            }

            Console.Write("Массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Среднее арифметическое: ");
            Console.WriteLine(AverageNumArray(nums));
        }
    }
}
