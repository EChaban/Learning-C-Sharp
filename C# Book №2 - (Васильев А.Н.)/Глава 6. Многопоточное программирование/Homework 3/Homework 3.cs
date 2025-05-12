/*Напишите программу, в которой символьный массив заполняется
с помощью двух дочерних потоков: первый поток заполняет элементы
с четными индексами латинскими буквами, а второй поток заполняет
элементы с нечетными индексами кириллическими буквами.*/

using System;
using System.Linq;
using System.Threading;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Enumerable.Repeat('*', 20).ToArray();

            Thread evenChars = new Thread(() => 
            {
                char symb = 'A';
                for (int i = 0; i < chars.Length / 2;)
                {
                    if (symb % 2 == 0)
                    {
                        chars[i] = symb;
                        i++;
                    }
                    symb += (char)1;
                }
            });

            Thread oddChars = new Thread(() =>
            {
                char symb = 'А';
                for (int i = chars.Length - 1; i > (chars.Length / 2) - 1;)
                {
                    if (symb % 2 != 0)
                    {
                        chars[i] = symb;
                        i--;
                    }
                    symb += (char)1;
                }
            });

            evenChars.Start();
            oddChars.Start();

            Console.WriteLine(chars);
        }
    }
}
