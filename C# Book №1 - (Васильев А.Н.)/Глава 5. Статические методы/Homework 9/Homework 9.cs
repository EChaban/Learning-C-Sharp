/*Напишите программу со статическим методом, аргументом которому
передается произвольное количество целочисленных аргументов. Результатом
метод возвращает массив из двух элементов: это значения наибольшего
и наименьшего значений среди аргументов, переданных методу.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static int[] MinMaxArray(params int[] array)
        {
            int[] maxMinValues = new int[2];
            maxMinValues[0] = array.Min();
            maxMinValues[1] = array.Max();
            return maxMinValues;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("5, 10, 11, 5, 2, 0, 1, 9");
            int[] maxMinValues = MinMaxArray(5, 10, 11, 5, 2, 0, 1, 9);
            Console.WriteLine($"Минимальное значение: {maxMinValues[0]}");
            Console.WriteLine($"Максимальное значение: {maxMinValues[1]}");
        }
    }
}
