/*Напишите программу, в которой объявляется переменная типа int,
а также указатель на указатель на значение типа char. С помощью этого
указателя нужно записать в первые два байта в области памяти, выде-
ленной под переменную типа int, символ 'A', а в следующие два бай-
та — символ 'B'. Проверьте значение целочисленной переменной и объ-
ясните результат.*/

using System;

namespace Homework_I0
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            char* p1 = (char*)&num;
            char** p2 = &p1;
            (*p2)[0] = 'A';
            (*p2)[1] = 'B';


            byte* pByte = (byte*)&num;
            Console.WriteLine("Получили число - " + num);
            Console.Write("Байты числа: ");
            for (int i = 0; i < sizeof(int); i++)
            {
                Console.Write(pByte[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
