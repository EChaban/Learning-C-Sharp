/*Напишите программу, в которой уравнение вида Ax = B решается
на множестве целых чисел. Решением является такое целое число x, ко-
торое, будучи умноженным на целое число A, дает целое число B. Ре-
шение существует только в том случае, если целое число B без остатка
делится на целое число A или если оба параметра A и B равны нулю.
Предусмотреть обработку исключительных ситуаций.*/

using System;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите множитель: ");
                int A = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите результат: ");
                int B = int.Parse(Console.ReadLine());

                if (A == 0 && B == 0) Console.WriteLine("x = любое целое число");
                else if (A == 0 && B != 0) Console.WriteLine("Решения нет");
                else if (A != 0 && B % A == 0) Console.WriteLine($"x = {B / A}");
                else if (A != 0 && B % A != 0) Console.WriteLine("Решения нет во множестве целых чисел");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
