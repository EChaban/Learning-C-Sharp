/*Напишите программу с перегруженным статическим методом. Если
аргументом методу передается два целых числа, то результатом возвращается
ссылка на целочисленный массив, состоящий из натуральных
чисел, а первое и последнее число в массиве определяется аргументами
метода. Например, если передать аргументами числа 2 и 4 , то результатом
будет массив из чисел 2, 3 и 4. Если аргументами методу передаются
два символьных значения, то результатом возвращается ссылка на массив,
состоящий из последовательности символов, а первый и последний
символы определяются аргументами метода. Например, если передать
аргументами методу символы 'В' и 'D', то в результате получим массив
из символов 'В', 'С' и 'D'.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Program
    {
        static int[] CreatArray(int firstValue, int lastValue)
        {
            if (firstValue > lastValue)
            {
                int tmp = firstValue;
                firstValue = lastValue;
                lastValue = tmp;
            }

            int[] intArray = new int[lastValue - firstValue + 1];
            for (int i = 0; i < intArray.Length; i++, firstValue++) intArray[i] = firstValue;
            return intArray;
        }

        static char[] CreatArray(char firstValue, char lastValue)
        {
            if (firstValue > lastValue)
            {
                char tmp = firstValue;
                firstValue = lastValue;
                lastValue = tmp;
            }

            char[] charArray = new char[lastValue - firstValue + 1];
            for (int i = 0; i < charArray.Length; i++, firstValue++) charArray[i] = firstValue;
            return charArray;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int lastNum = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Получен массив: ");
            int[] intArray = CreatArray(firstNum, lastNum);
            for (int i = 0; i < intArray.Length; i++)
                Console.Write("| " + intArray[i] + " ");
            Console.Write("|");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Введите первый символ: ");
            char firstChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второй символ: ");
            char lastChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Получен массив: ");
            char[] charArray = CreatArray(firstChar, lastChar);
            for (int i = 0; i < charArray.Length; i++)
                Console.Write("| " + charArray[i] + " ");
            Console.Write("|");

            Console.WriteLine();
        }
    }
}
