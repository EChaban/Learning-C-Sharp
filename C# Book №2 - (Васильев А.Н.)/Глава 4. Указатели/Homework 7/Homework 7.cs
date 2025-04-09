/*Напишите программу, в которой создается массив из двух элементов
типа int. Заполните этот массив по байтам последовательностью нату-
ральных чисел. Проверьте значения байтов, значения элементов цело-
численного массива и объясните результат.*/

using System;
using System.Xml.XPath;

namespace Homework_7
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[2] { 555, 666};
            
            fixed (int* pnt = ints) 
            {
                //Console.WriteLine(pnt[0] + " " + pnt[1]);

                int* pInt;
                byte* pByte;
                byte counter = 1;

                for (int i = 0; i < ints.Length; i++)
                {
                    pInt = &pnt[i];
                    pByte = (byte*)pInt;
                    for (int j = 0; j < sizeof(int); j++, counter++)
                    {
                        pByte[j] = counter;
                    }
                }

                Console.WriteLine("Значения в масиве: ");
                foreach (int n in ints)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Байтовые заначения чисел масива:");
                for (int i = 0; i < ints.Length; i++)
                {
                    Console.Write($"Значения числа {ints[i]}: ");
                    pByte = (byte*)&pnt[i];
                    for (int j = 0; j < sizeof(int); j++)
                    {
                        Console.Write(pByte[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
