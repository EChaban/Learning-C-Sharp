/*Напишите программу, в которой пользователь вводит дату своего ро-
ждения, а программа вычисляет, сколько прошло полных лет, месяцев
и дней от указанной даты до текущей.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату вашего рождения: ");
            string strBirthDay = Console.ReadLine();
            DateTime dateNow = DateTime.Now;
            DateTime dateBirthDay = DateTime.Parse(strBirthDay);
            int years = dateNow.Year - dateBirthDay.Year;
            int months = dateNow.Month - dateBirthDay.Month;
            int days = dateNow.Day - dateBirthDay.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(dateNow.Year, dateNow.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев, {days} дней");
        }
    }
}
