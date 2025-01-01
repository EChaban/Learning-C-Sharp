/*Напишите программу, в которой есть структура с двумя целочислен-
ными полями. Предложите статический метод, аргументом которому пе-
редается целочисленный массив. Результатом метод возвращает экзем-
пляр структуры, первое поле которого равно значению максимального
(или минимального) элемента в массиве, а второе поле экземпляра рав-
но индексу этого элемента в массиве.*/

using System;
using System.Linq;

namespace Homework_9
{
    internal class Program
    {
        public static MaxNumOfArray SetNumFromArray(int[] nums)
        {
            int max = nums.Max();
            int index = Array.FindIndex(nums, x => x == max);
            return new MaxNumOfArray(max, index);
        }

        public struct MaxNumOfArray
        {
            int maxNum;
            int indexNum;

            public MaxNumOfArray(int max, int index)
            {
                maxNum = max;
                indexNum = index;
            }

            public void Print()
            {
                Console.WriteLine($"{maxNum}, {indexNum}");
            }
        }

        static void Main(string[] args)
        {
            MaxNumOfArray test = new MaxNumOfArray();
            int[] ints = { 1, 2, 3 };
            test = SetNumFromArray(ints);
            test.Print();
        }
    }
}
