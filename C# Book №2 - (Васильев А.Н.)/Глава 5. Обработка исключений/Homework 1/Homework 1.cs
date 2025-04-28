/*Напишите программу, в которой пользователь вводит через консоль
размер целочисленного массива. Массив создается, заполняется нату-
ральными числами, а затем содержимое массива отображается в кон-
сольном окне. Предусмотреть обработку исключений, связанных с тем,
что пользователь ввел некорректное значение для размера массива или
ввел нечисловое значение.*/

using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool switcher = true;
            while (switcher == true) {
                try
                {
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] array = new int[size];

                    for (int i = 0; i < size; i++) array[i] = i + 1;
                    foreach (var i in array) Console.Write(i + " ");
                    Console.WriteLine();
                    switcher = false;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Ошибка: " + exp.GetType().Name);
                    Console.WriteLine("Описание: " + exp.Message);
                    Console.WriteLine("Требуется повторный ввод размера массива!");
                    Console.WriteLine();
                }
            }
        }
    }
}
