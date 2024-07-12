/*Напишите программу со статическим методом, которому аргументом
передается целочисленный массив и целое число. Результатом метод
возвращает ссылку на новый массив, который получается из исходного
массива (переданного первым аргументом методу), если в нем взять несколько
начальных элементов. Количество элементов, которые нужно
взять из исходного массива, определяются вторым аргументом метода.
Если второй аргумент метода больше длины массива, переданного первым
аргументом, то методом создается копия исходного массива и возвращается
ссылка на эту копию.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static int[] NewArray(int[] nums, int n)
        {
            if (n > nums.Length) n = nums.Length;
            int[] newNums = new int[n];

            for (int i = 0; i < n && i < nums.Length; i++)
            {
                newNums[i] = nums[i];
            }
            return newNums;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(40);
            int[] nums = new int[rnd.Next(20)];
            for(int i = 0; i < nums.Length; i++) nums[i] = rnd.Next(101);

            Console.WriteLine("Число n: " + n);

            Console.WriteLine();

            Console.Write($"Массив длинной {nums.Length}: ");
            for(int i = 0; i < nums.Length; i++) Console.Write(nums[i] + " ");

            Console.WriteLine();
            Console.WriteLine();

            int[] newNums = NewArray(nums, n);
            Console.Write($"Новый массив длинной {newNums.Length}: ");
            for (int i = 0; i < newNums.Length; i++) Console.Write(nums[i] + " ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
