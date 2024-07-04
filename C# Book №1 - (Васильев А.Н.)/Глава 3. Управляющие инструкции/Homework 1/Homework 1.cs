/*Напишите программу, в которой пользователь вводит число, а программа
проверяет, делится ли это число на 3 и на 7 . Результаты проверки
отображаются в сообщении в диалоговом окне. Используйте обработку
исключений.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_1
{
    internal static class Program
    {
        static void Main()
        {
        start:
            try
            {
                int num = int.Parse(Interaction.InputBox("Введите число", ""));
                if (num % 3 == 0 && num % 7 == 0)
                {
                    MessageBox.Show("Число делиться на 3 и 7", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Число не делиться на 3 и 7", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Нужно ввести число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto start;
            }
        }
    }
}
