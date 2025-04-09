/*Напишите программу, в которой есть класс с целочисленным полем.
На основе класса создайте объект. С помощью указателей запишите
в первые два байта области памяти, выделенной под поле объекта, сим-
вол 'A', а в два следующие байта — символ 'B'. Проверьте значение
поля и объясните результат.*/

using System;

namespace Homework_6
{
    unsafe internal class Program
    {
        class MyClass
        {
            public int num;
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.num);
            myClass.num = 55;
            Console.WriteLine(myClass.num);
            fixed (int* pnt = &myClass.num)
            {
                Console.WriteLine(*pnt);
                char* a, b;
                a = (char*)pnt;
                b = &a[1];
                *a = 'A';
                *b = 'B';
                Console.WriteLine("Байтовое значение \'A\':" + ((byte)'A'));
                Console.WriteLine("Байтовое значение \'B\':" + ((byte)'B'));
                Console.WriteLine(*pnt);

                byte* pByte = (byte*)pnt; // Приводим int* к byte*

                Console.WriteLine($"Число: {*pnt}");
                Console.WriteLine("Байты (по порядку хранения в памяти):");

                for (int i = 0; i < sizeof(int); i++)
                {
                    Console.Write(pByte[i] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
