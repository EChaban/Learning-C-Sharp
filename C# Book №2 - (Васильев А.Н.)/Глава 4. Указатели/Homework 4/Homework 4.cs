/*Напишите программу, в которой объявляется переменная типа int.
Переменной в качестве значения присваивается случайное число. Затем
(с использованием указателей) выполняется циклический сдвиг байтов:
первый байт становится вторым, второй байт становится третьим, тре-
тий байт становится четвертым, а четвертый байт становится первым.
Предложите способ проверки правильности вычислений.*/

using System;

namespace Homework_4
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next();
            byte* p = (byte*)&n;
            byte *[] bytes = new byte*[sizeof(int)];
            byte *[] temp = new byte*[sizeof(int)];

            for (int i = 0; i < sizeof(int); i++)
            {
                bytes[i] = &p[i];
            }

            byte* tmp = bytes[bytes.Length - 1];

            Console.WriteLine(n);
            Console.WriteLine("Байты числа");
            for (int i = 0; i < sizeof(int); i++)
            {
                Console.Write(p[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Байты массива указателей");
            for (int i = 0; i < sizeof(int); i++)
            {
                Console.Write(*bytes[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < bytes.Length; i++)

            {
                temp[(i + 1) % bytes.Length] = bytes[i];
            }

            Array.Copy(temp, bytes, sizeof(int));

            Console.WriteLine();
            Console.WriteLine("Байты массива указателей после смещения");
            for (int i = 0; i < sizeof(int); i++)
            {
                Console.Write(*bytes[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
