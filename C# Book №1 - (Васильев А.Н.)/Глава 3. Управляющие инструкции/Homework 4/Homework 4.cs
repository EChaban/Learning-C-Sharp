/*Напишите программу, в которой пользователь вводит целое число
в диапазоне от 1 до 7 , а программа определяет по этому числу день недели.
Если введенное пользователем число выходит за допустимый диапазон,
выводится сообщение о том, что введено некорректное значение.
Используйте оператор выбора switch. Предложите механизм обработки
ошибки, связанной с вводом нечислового значения.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 7: ");
            start:
            try
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Введите чсило в диапазоне 1-7");
                        goto start;
                }
            }
            catch 
            {
                Console.WriteLine("Ошибка!");
                Console.WriteLine("Ввидите числовое значение!\n");
                goto start;
            }
            
        }
    }
}
