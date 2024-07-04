/* Напишите программу для вычисления суммы двух чисел. Оба числа
вводятся пользователем. Для вычисления суммы используйте оператор
+ . Предложите два варианта программы: программу, в которой данные
вводятся и выводятся с помощью диалоговых окон, и программу,
в которой используется консольный ввод и вывод данных. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_8._1
{
    internal static class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Interaction.InputBox("Введите первое число", "Число №1"));
            int secondNumber = int.Parse(Interaction.InputBox("Введите воторое число", "Число №2"));
            MessageBox.Show("Сумма чисел = " + (firstNumber + secondNumber), "Сумма чисел", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
