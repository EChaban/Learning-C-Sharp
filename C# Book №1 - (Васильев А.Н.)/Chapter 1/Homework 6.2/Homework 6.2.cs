/* Напишите программу, в которой пользователь водит имя и год рождения,
а программа отображает сообщение, содержащее имя пользователя
и его возраст. Предложите консольную версию программы. */

using System;

namespace Homework_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Данные пользователя";
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.Write("Какой у вас год рождения? ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваши данные: " + name + " " + (DateTime.Now.Year - yearOfBirth) + " лет.");
        }
    }
}
