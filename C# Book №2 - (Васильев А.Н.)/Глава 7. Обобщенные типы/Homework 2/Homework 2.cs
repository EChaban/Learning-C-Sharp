/*Напишите программу, в которой есть статический обобщенный метод.
Метод не возвращает результат, а аргументом методу передается массив
с элементами обобщенного типа. При вызове метода выполняется ци-
клическая перестановка элементов массива: первый элемент становит-
ся вторым, второй элемент становится третьим, и так далее, а последний
элемент становится первым.*/

using System;

namespace Homework_2
{
    internal class Program
    {
        static void ShiftArray<T>(T[] array)
        {
            T tmp = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--) array[i] = array[i - 1];
            array[0] = tmp;
        }

        static void Main(string[] args)
        {
            char[] chars = { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine(chars);
            ShiftArray(chars);
            Console.WriteLine(chars);
        }
    }
}
