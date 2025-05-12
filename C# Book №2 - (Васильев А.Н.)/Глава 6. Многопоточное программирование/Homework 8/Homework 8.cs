/*Напишите программу, в которой создается двумерный символьный
массив. Массив заполняется случайными символами. Заполнение вы-
полняется по столбикам. Для заполнения каждого столбика запускается
отдельный дочерний поток.*/

using System;
using System.Threading;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chars = new char[10, 10];

            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                int iLocal = i;
                threads[i] = new Thread(() =>
                {
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        int jLocal = j;
                        chars[jLocal, iLocal] = (char)rnd.Next(65, 91);
                    }
                });
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            for (int i = 0; i < chars.GetLength(1) ; i++)
            {
                for (int j = 0;j < chars.GetLength(0); j++)
                {
                    Console.Write(chars[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
