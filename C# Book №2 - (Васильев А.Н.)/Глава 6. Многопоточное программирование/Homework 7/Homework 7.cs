/*Напишите программу, в которой создается двумерный целочислен-
ный массив. Массив заполняется построчно: первая строка заполняется
числами, являющимися степенями двойки, вторая строка заполняется степенями тройки.
Для заполнения каждой строки запускается дочерний поток. Объектные
переменные для потоков следует организовать в виде массива.*/

using System;
using System.Threading;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[2, 5];

            Thread[] ints0Thread = new Thread[5];
            Thread[] ints1Thread = new Thread[5];

            for (int i = 0; i < ints.GetLength(1); i++)
            {
                int localI = i;
                ints0Thread[i] = new Thread(() => { ints[0, localI] = (int)(Math.Pow(2, localI)); });
                ints1Thread[i] = new Thread(() => { ints[1, localI] = (int)(Math.Pow(3, localI)); });
            }

            for(int i = 0; i < ints.GetLength(1); i++)
            {
                ints0Thread[i].Start();
                ints1Thread[i].Start();
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for(int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
