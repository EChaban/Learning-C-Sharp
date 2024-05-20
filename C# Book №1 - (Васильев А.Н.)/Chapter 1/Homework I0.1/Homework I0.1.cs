/* Напишите программу, в которой пользователь вводит два числа, а программой
вычисляется и отображается сумма и разность этих чисел. Предложите
варианты программы с использованием консольного ввода/вывода
данных и ввода и вывода данных с помощью диалоговых окон. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_I0._1
{
    internal static class Program
    {
    {
        static void Main()
        {
            int num1 = int.Parse(Interaction.InputBox("Введите первое число:"));
            int num2 = int.Parse(Interaction.InputBox("Введите второе число:"));
            MessageBox.Show("Разность чисел: " + " " + (num1-num2), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
