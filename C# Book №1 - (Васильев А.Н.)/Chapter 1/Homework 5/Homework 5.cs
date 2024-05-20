/* Напишите программу, в которой по году рождения определяется возраст
пользователя. Используйте консольный ввод и вывод данных. */

using System;
using System.Data;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш год рождения: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - yearOfBirth;
            Console.WriteLine("В этом году вам исполнилось/исполниться: " + age + " лет.");
        }
    }
}
