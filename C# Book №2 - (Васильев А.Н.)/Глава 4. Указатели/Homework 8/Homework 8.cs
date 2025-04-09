/*Напишите программу, в которой объявляется переменная типа
double и одномерный массив, элементы которого являются указателя-
ми на значение типа byte. В этот массив записываются адреса однобай-
товых блоков из области памяти, выделенной под double-переменную,
но через один: адрес первого блока, третьего, пятого и так далее. Исполь-
зуя этот массив указателей путем их индексирования, следует заполнить
все байты в области памяти, выделенной под double-переменную, по-
следовательностью натуральных чисел и проверить результат.*/

using System;

namespace Homework_8
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            byte*[] bytes = new byte*[sizeof(double) / 2];

            double* tmpNum = &num;
            byte* tmpByte = (byte*)&num;


            for (byte i = 0, n = 1; i < sizeof(double); i++, n++)
            {
                tmpByte[i] = n;
            }

            Console.WriteLine("Получено число " + num);
            Console.Write("Байты данного числа: ");
            for (int i = 0; i < sizeof(double); i++)
            {
                Console.Write(tmpByte[i] + " ");
            }
            Console.WriteLine();

            for (byte i = 0, k = 0; i < bytes.Length; i++, k+=2)
            {
                bytes[i] = &tmpByte[i];
            }

            Console.Write("Массив указателей: ");
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(*bytes[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
