using System;
using System.Collections.Generic;

namespace Homework_I0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int firstKey = 1;
            int secondKey = 2;
            int nextKey;

            Dictionary<int, char> dictionary = new Dictionary<int, char>();

            // Добавляем первые два ключа
            dictionary[firstKey] = (char)rnd.Next(65, 91);
            dictionary[secondKey] = (char)rnd.Next(65, 91);

            // Добавляем еще 8 элементов (всего 10)
            for (int i = 0; i < 8; i++)
            {
                nextKey = firstKey + secondKey;
                dictionary[nextKey] = (char)rnd.Next(65, 91);
                firstKey = secondKey;
                secondKey = nextKey;
            }

            // Выводим ключи и значения в порядке добавления
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}