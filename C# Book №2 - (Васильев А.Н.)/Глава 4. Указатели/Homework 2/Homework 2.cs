/*Напишите программу, в которой объявляется переменная типа
double. В область памяти, выделенную под эту переменную, запишите
такие значения: в первый байт запишите значение 1, в следующие два
байта запишите символ 'A', в следующие четыре байта запишите зна-
чение 2 и в оставшийся восьмой байт запишите значение 3.*/

using System;

namespace Homework_2
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double n = 0;
            byte* pByte = (byte*)&n;

            *pByte = (byte)1;

            char* pChar = (char*)&pByte[1];
            *pChar = 'A';

            int* pInt = (int*)&pByte[3];
            *pInt = 2;

            pByte[7] = (byte)3;

            for (int i = 0; i < sizeof(double); i++)
            {
                Console.WriteLine(pByte[i]);
            }
        }
    }
}
