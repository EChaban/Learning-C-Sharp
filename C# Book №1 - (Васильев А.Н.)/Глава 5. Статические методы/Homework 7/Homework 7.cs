/*Напишите программу со статическим методом, аргументом которому
передается одномерный символьный массив. В результате вызова метода
элементы массива попарно меняются местами: первый - с последним,
второй - с предпоследним и так далее.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static void ChangeArray(char[] chars, int[] numOfElements)
        {
            char tmp;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                tmp = chars[0 + i];
                chars[0 + i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = tmp;
            }

            int tmp2;
            for (int i = 0; i < numOfElements.Length / 2; i++)
            {
                tmp2 = numOfElements[0 + i];
                numOfElements[0 + i] = numOfElements[numOfElements.Length - 1 - i];
                numOfElements[numOfElements.Length - 1 - i] = tmp2;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            int[] numOfElements = new int[chars.Length];
            for (int i = 0; i < numOfElements.Length; i++) numOfElements[i] = i;

            Console.Write("Массив: ");
            for (int i = 0;i < chars.Length; i++) Console.Write(chars[i] + " ");
            Console.WriteLine();

            Console.Write("Индекс: ");
            for (int i = 0; i < numOfElements.Length; i++) Console.Write(numOfElements[i] + " ");
            Console.WriteLine();

            ChangeArray(chars, numOfElements);
            Console.WriteLine();
            Console.WriteLine("Массив после применения метода:");

            Console.Write("Массив: ");
            for (int i = 0; i < chars.Length; i++) Console.Write(chars[i] + " ");
            Console.WriteLine();

            Console.Write("Индекс: ");
            for (int i = 0; i < numOfElements.Length; i++) Console.Write(numOfElements[i] + " ");
            Console.WriteLine();
        }
    }
}
