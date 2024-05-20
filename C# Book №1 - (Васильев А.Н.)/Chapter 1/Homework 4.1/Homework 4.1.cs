/* Напишите программу, в которой пользователю предлагается ввести
название месяца и количество дней в этом месяце. Программа выводит
сообщение о том, что соответствующий месяц содержит указанное количество
дней. Предложите версии программы для ввода/вывода данных
с помощью диалоговых окон. */

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Homework_4._1
{
    internal static class Program
    {
        static void Main()
        {
            int month = Convert.ToInt32(Interaction.InputBox("Введите номер месяца 1-12", "Месяц"));
            DateTime.DaysInMonth(DateTime.Now.Year, month);
            MessageBox.Show("Кол-во дней в месяце " +  "\"" +DateAndTime.MonthName(month, true)+ "\"" + " = " + DateTime.DaysInMonth(DateTime.Now.Year, month), "Месяц", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
