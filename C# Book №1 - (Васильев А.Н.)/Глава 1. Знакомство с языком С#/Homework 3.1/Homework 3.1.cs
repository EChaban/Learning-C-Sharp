/* Напишите программу, в которой пользователь последовательно вводит
название текущего дня недели, название месяца и дату (номер дня
в месяце). Программа выводит сообщение о сегодняшней дате (день
недели, дата, месяц). Используйте версию программы, в которой для ввода и вывода данных
используются диалоговые окна. */

using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Homework_3._1
{
    internal static class Program
    {
        static void Main()
        {
            string dayOfWeek = Interaction.InputBox("Ввведите сегодняшний день недели: ", "День недели");
            string month = Interaction.InputBox("Ввведите текущий месяц: ", "Месяц");
            string day = Interaction.InputBox("Ввведите текущий день: ", "День");

            MessageBox.Show(dayOfWeek + " " + day + " " + month, "Сегодняшняя дата", MessageBoxButtons.OK);
        }
    }
}
