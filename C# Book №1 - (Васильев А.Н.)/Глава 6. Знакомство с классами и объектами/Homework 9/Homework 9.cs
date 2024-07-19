/*Напишите программу с классом, в котором есть статические методы,
которым можно передавать произвольное количество целочисленных
аргументов (или целочисленный массив). Методы, на основании переданных
аргументов или массива, позволяют вычислить: наибольшее значение,
наименьшее значение, а также среднее значение из набора чисел.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    class MinAverageMax
    {
        public static void Parse(params int[] nums)
        {
            Console.WriteLine("Min: " + nums.Min());
            Console.WriteLine("Max: " + nums.Max());
            Console.WriteLine("Average: " + nums.Average());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1, 2, 3, 4");
            MinAverageMax.Parse(1, 2, 3, 4);
            Console.WriteLine();

            Console.WriteLine("2, 3, 4, 5, 6");
            MinAverageMax.Parse(2, 3, 4, 5, 6);
            Console.WriteLine();

            Console.WriteLine("3, 4, 5, 6, 7, 8, 9, 10");
            MinAverageMax.Parse(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]");
            MinAverageMax.Parse(nums);
            Console.WriteLine();
        }
    }
}
