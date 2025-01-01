/*Напишите программу, в которой объявляется перечисление для пред-
ставления дней недели. Предложите методы (или добавьте в главный
метод блоки кода), позволяющие по числовому значению определить
день недели (с учетом периодической повторяемости дней), а также по-
зволяющие по двум значениям из перечисления определить минималь-
ное количество дней между соответствующими днями недели.*/

using System;

namespace Homework_1
{
    enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    internal class Program
    {
        static public DaysOfWeek GetDay (int num)
        {
            DaysOfWeek tmp = (DaysOfWeek)(num % 7);
            return tmp;
        }

        static public int GetAmountOfDays(DaysOfWeek firstDay, DaysOfWeek secondDay)
        {
            int count = 0;
            firstDay++;
            while (firstDay != secondDay)
            {
                firstDay = (DaysOfWeek)(((int)firstDay + 1) % 7); // Переход к следующему дню
                count++;
            }
            return count;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"{GetDay(0)}, {GetDay(2)}, {GetDay(6)}, {GetDay(10)} \n");

            DaysOfWeek first = DaysOfWeek.Monday;
            DaysOfWeek second = DaysOfWeek.Friday;
            Console.WriteLine($"{GetAmountOfDays(first, second)}");
        }
    }
}
