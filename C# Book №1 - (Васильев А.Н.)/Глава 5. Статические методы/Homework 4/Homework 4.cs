/*Напишите программу со статическим методом, аргументом которому
передается символьный массив, а результатом возвращается ссылка
на целочисленный массив, состоящий из кодов символов из массива аргумента.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static int[] ConvertArray(char[] chArray)
        {
            int[] intArray = new int[chArray.Length];
            for (int i = 0; i < chArray.Length; i++)
            {
                intArray[i] = chArray[i];
            }
            return intArray;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] chArray = new char[rnd.Next(5, 11)];

            for (int i = 0; i < chArray.Length; i++)
            {
                chArray[i] = (char)rnd.Next(65, 91);
            }

            Console.Write("Первоначальный массив: ");
            for (int i = 0; i < chArray.Length; i++)
            {
                Console.Write(chArray[i] + " ");
            }

            int[] intArray = ConvertArray(chArray);

            Console.WriteLine(); Console.WriteLine();

            Console.Write("Изменённый массив: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
