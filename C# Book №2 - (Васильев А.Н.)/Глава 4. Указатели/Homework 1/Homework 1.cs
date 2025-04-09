/*Напишите программу, в которой объявляется переменная типа int.
В первый и последний байты области памяти, выделенной под эту пере-
менную, запишите число 1, а в два внутренних байта запишите символ 'A'.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int n = 0;
            byte* BytePointer;
            char* CharPointer;
            BytePointer = (byte*)&n;
            *BytePointer = 1;
            BytePointer[sizeof(int) / sizeof(byte) - 1] = 1;
            Console.WriteLine($"{*BytePointer}, {BytePointer[3]}");

            CharPointer = (char*)&BytePointer[1];
            *CharPointer = 'A';

            Console.WriteLine($"{*CharPointer}");

            // Проверка: выводим все байты переменной n
            Console.WriteLine("Проверка байтов переменной n:");
            for (int i = 0; i < sizeof(int); i++)
            {
                Console.WriteLine($"Байт {i}: {BytePointer[i]}");
            }
        }
    }
}
