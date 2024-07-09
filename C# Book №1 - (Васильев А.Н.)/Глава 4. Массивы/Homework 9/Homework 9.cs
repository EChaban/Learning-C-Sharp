/*Напишите программу, в которой создается и инициализируется двумерный
числовой массив. Затем из этого массива удаляется строка
и столбец (создается новый массив, в котором по сравнению с исходным
удалена одна строка и один столбец). Индекс удаляемой строки
и индекс удаляемого столбца определяется с помощью генератора случайных
чисел.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] ints = new int[rnd.Next(2,6), rnd.Next(2, 6)];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(1, 101);
                }
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j]+"\t");
                }
                Console.WriteLine();
            }

            int[,] newInts = new int[ints.GetLength(0) - 1, ints.GetLength(1) - 1];
            int numRow = rnd.Next(0, ints.GetLength(0));
            int numColumn = rnd.Next(0, ints.GetLength(1));

            for (int i = 0, i2 = 0; i < newInts.GetLength(0); i++, i2++)
            {
                if (i2 == numRow)
                {
                    i--;
                    continue;
                }
                for (int j = 0, j2 = 0; j < newInts.GetLength(1); j++, j2++)
                {
                    if (j2 == numColumn)
                    {
                        j--;
                        continue;
                    }
                    newInts[i, j] = ints[i2, j2];
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Новый массив, без строки - {numRow}, и столбца {numColumn}:");
            for (int i = 0; i < newInts.GetLength(0); i++)
            {
                for (int j = 0; j < newInts.GetLength(1); j++)
                {
                    Console.Write(newInts[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
