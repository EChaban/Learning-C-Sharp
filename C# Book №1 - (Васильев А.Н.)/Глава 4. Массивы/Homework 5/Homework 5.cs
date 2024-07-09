/*Напишите программу, в которой создается массив и заполняется случайными
числами. Массив отображается в консольном окне. В этом
массиве необходимо определить элемент с минимальным значением.
В частности, программа должна вывести значение элемента с минимальным
значением и индекс этого элемента. Если элементов с минимальным
значением несколько, должны быть выведены индексы всех этих
элементов.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] ints = new int[rnd.Next(10, 50)];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(1, 101);
            }

            foreach (int i in ints) Console.Write(i + " ");
            Console.WriteLine();

            int minValue = ints.Min();
            Console.WriteLine("Число с минимальным значением: " + minValue);

            Console.Write("Индекс минимального значегния: ");
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == minValue) Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
