/*Напишите программу, содержащую структуру с целочисленным
массивом. Опишите конструктор с одним аргументом, определяющим
размер массива. Массив должен заполняться случайными числами.
В структуре должны быть методы, возвращающие результатом наиболь-
ший элемент в массиве, наименьший элемент в массиве, а также метод,
возвращающий среднее значение элементов в массиве (сумма элементов
массива, деленная на количество элементов в массиве).*/

using System;
using System.Linq;

namespace Homework_4
{
    struct MyStruct
    {
        int[] ints;
        public MyStruct(int n)
        {
            ints = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++) ints[i] = rnd.Next(101);
        }

        public int Max() { return ints.Max(); }
        public int Min() { return ints.Min(); }
        public double Average() { return ints.Average(); }

        public void Print()
        {
            foreach (int i in ints) Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct s = new MyStruct(5);
            s.Print();

            Console.WriteLine(s.Max());
            Console.WriteLine(s.Min());
            Console.WriteLine(s.Average());
        }
    }
}