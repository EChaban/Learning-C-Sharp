/*Напишите программу, в которой пользователь последовательно вводит
два целых числа. Программа определяет, какое из чисел больше или
они равны, и выводит сообщение в диалоговом окне. Используйте обработку
исключений.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_2
{
    internal static class Program
    {
        static void Main()
        {
            start:
            try
            {
                int num1 = int.Parse(Interaction.InputBox("Введите первое целое число", "Первое число"));
                int num2 = int.Parse(Interaction.InputBox("Введите второе целое число", "Второе число"));

                if (num1 > num2)
                {
                    MessageBox.Show("Первое число больше", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (num1 < num2)
                {
                    MessageBox.Show("Второе число больше", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Числа равны", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Числа введены не верно!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto start;
            }
        }
    }
}
