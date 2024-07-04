/* Напишите программу, в которой пользователь вводит имя и возраст.
Программа отображает сообщение об имени и возрасте пользователя.
Предложите консольную версию программы. */

using System;

namespace Homework_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день рождения: ");
            int day = Convert.ToInt32(Console.ReadLine());

            int nowYear = Convert.ToInt32(DateTime.Now.Year);
            int nowMonth = Convert.ToInt32(DateTime.Now.Month);
            int nowDay = Convert.ToInt32(DateTime.Now.Day);

            int age = nowYear - year;
            if (month > nowMonth)
            {
                age -= 1;
            }
            else if(month == nowMonth)
            {
                if (day > nowDay)
                {
                    age -= 1;
                }
            }

            Console.WriteLine("Ваши данные: " + name + " " + age + " лет");
        }
    }
}
