/* Напишите программу, в которой пользователь вводит сначала имя,
а затем фамилию. Программа выводит сообщение с информацией
об имени и фамилии пользователя. Предложите версию программы,
в которой ввод и вывод текста осуществляется с помощью консольную версию программы. */

using System;

namespace Homework_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            Console.Title = "Имя";
            Console.Write("Как ваше имя? ");
            name = Console.ReadLine();
            Console.Title = "Фамилия";
            Console.Write("Как ваша фамилия? ");
            surname = Console.ReadLine();
            Console.Title = "Приятно познакомится!";
            Console.WriteLine("Приятно познакомится " + name + " " + surname + "!");
            Console.ReadKey();
        }
    }
}
