/*Напишите программу, содержащую статический метод с аргументом,
являющимся целочисленным массивом. Результатом метод возвращает
стек, состоящий из тех элементов массива, значение которых не меньше
среднего значения по массиву.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework_9
{
    internal class Program
    {
        static Stack<int> AverageNums(int[] nums)
        {
            double average = nums.Average();
            Stack<int> result = new Stack<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= average)
                    result.Push(nums[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Stack<int> stack = AverageNums(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
        }
    }
}
