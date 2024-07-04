/* Напишите программу, в которой пользователь вводит число, а программой
отображается последовательность из трех чисел: число, на единицу
меньшее введенного, введенное число и число, на единицу большее
введенного. Предложите версию программы с консольным вводом
и выводом данных, а также версию программы, в которой ввод и вывод
выполняется с помощью диалоговых окон. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_9._1
{
    internal static class Program
    {
        static void Main()
        {
            int num = int.Parse(Interaction.InputBox("Введите число"));
            MessageBox.Show((num-1) + "\t" + num + "\t" + (num+1),"", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
