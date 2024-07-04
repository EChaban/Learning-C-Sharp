/*Напишите программу, которая проверяет, попадает ли введенное
пользователем число в диапазон от 5 до 1О включительно.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_4
{
    internal static class Program
    {
        static void Main()
        {
            int num = int.Parse(Interaction.InputBox("Введите число", "Ввод числа"));
            if (num >= 5 && num <= 10)
            {
                MessageBox.Show("Попадает в диапазон от 5 до 10 включительно.", "Соответствует", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не попадает в диапазон от 5 до 10 включительно.", "Не соответствует", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
