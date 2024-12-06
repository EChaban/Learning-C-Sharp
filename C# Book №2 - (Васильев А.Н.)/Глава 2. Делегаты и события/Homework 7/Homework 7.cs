/*Напишите программу, содержащую статический метод. Первым ар-
гументом статическому методу передается целочисленный массив. Вто-
рым аргументом статическому методу передается ссылка на другой ме-
тод. У метода-аргумента должен быть целочисленный аргумент, и он
должен возвращать целочисленный результат. Результатом статический
метод возвращает целочисленный массив. Элементы этого массива вы-
числяются как результат вызова метода-аргумента, если ему передавать
значения элементов из массива-аргумента. Предложите механизм про-
верки функциональности данного статического метода.*/

using System;

namespace Homework_7
{
    internal class Program
    {
        delegate int MyDelegate(int num);
        static int[] CalculateArrayWithMethod(int[] array, MyDelegate method)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = method(array[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5};
            array = CalculateArrayWithMethod(array, num => num * 2);
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
