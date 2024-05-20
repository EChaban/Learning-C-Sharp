/* Напишите программу, в которой по возрасту определяется год рождения.
Предложите вариант программы, в которой используется консольный ввод и вывод данных. */

using System;

namespace Homework_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Определение года рождения";
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы " + (DateTime.Now.Year - age) + " года рождения.");
        }
    }
}
