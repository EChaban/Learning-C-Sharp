/*Напишите программу, в которой создается текстовый объект, а потом
с помощью указателей непосредственно в этом объекте выполняется ин-
версия текста: порядок символов заменяется на противоположный.*/

using System;

namespace Homework_9
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            fixed (char* p = text) {
                Console.WriteLine("\nИнверсия текста: ");
                char*[] pText = new char*[text.Length];

                // Копирование текста в символьный массив указателей
                for (int i = 0; i < pText.Length; i++)
                {
                    pText[i] = &p[i];
                }

                // Инвертируем текст используя массив указателей
                char c1, c2;
                for (int i = 0; i < pText.Length / 2; i++)
                {
                    c1 = *pText[i];
                    c2 = *pText[pText.Length - i - 1];
                    *pText[i] = c2;
                    *pText[pText.Length - i - 1] = c1;
                }

                Console.WriteLine(text);
            }
        }
    }
}
