/*Напишите программу с классом, в котором есть двумерный числовой
массив. Опишите два индексатора для класса. Двумерный индексатор
с двумя целочисленными индексами позволяет прочитать и изменить
значение элемента в двумерном массиве, а индексатор с одним целочисленным
индексом возвращает результатом значение наибольшего
элемента в строке двумерного массива. Присваивание значения выражению
на основе объекта с одним индексом означает присваивание
значения тому элементу в строке, который на данный момент имеет
наибольшее значение. Строка определяется индексом, указанным при
индексировании объекта. Если в строке несколько элементов с наибольшим
значением, то используется первый такой элемент.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        class MyClass
        {
            private int[,] ints;

            public MyClass(int[,] ints)
            {
                this.ints = ints;
            }

            public int this[int i, int j]
            {
                get { return ints[i, j]; }
                set { ints[i, j] = value; }
            }

            public int this[int i]
            {
                get 
                {
                    int max = 0;
                    for (int j = ints.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (ints[i, j] > max) max = ints[i, j];
                    }
                    return max;
                }
                set 
                {
                    int max = 0;
                    int secondIndex = 0;
                    for (int j = ints.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (ints[i, j] > max)
                        {
                            max = ints[i, j];
                            secondIndex = j;
                        }
                    }
                    ints[i, secondIndex] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };

            MyClass obj = new MyClass(myArray);

            Console.WriteLine(obj[0, 2]);
            Console.WriteLine(obj[1, 2]);
            Console.WriteLine(obj[2, 2]);
            obj[0, 2] = 11;
            obj[1, 2] = 22;
            obj[2, 2] = 32;
            Console.WriteLine(obj[0, 2]);
            Console.WriteLine(obj[1, 2]);
            Console.WriteLine(obj[2, 2]);
            obj[0] = 111;
            obj[1] = 122;
            obj[2] = 132;
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
        }
    }
}
