/*Напишите программу, в которой создается одномерный целочислен-
ный массив и запускаются два дочерних потока. Один дочерний поток
выполняет поиск элемента с наибольшим значением, а второй поток вы-
полняет поиск элемента с наименьшим значением. Найденные значения
отображаются в консольном окне.*/

using System;
using System.Linq;
using System.Threading;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] ints = new int[rnd.Next(25, 51)];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(101);
            }

            Console.WriteLine(string.Join(", ", ints));

            Thread maxValue = new Thread(() =>
            {
                Console.WriteLine(ints.Max());
            });

            Thread minValue = new Thread(() =>
            {
                Console.WriteLine(ints.Min());
            });

            maxValue.Start();
            minValue.Start();
        }
    }
}
