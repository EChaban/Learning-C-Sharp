/*Напишите программу, которая проверяет вторую справа цифру в восьмеричном
представлении числа, введенного пользователем. Число вводится
в десятичном (обычном) представлении.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_6
{
    internal static class Program
    {
        static void Main()
        {
            int num = int.Parse(Interaction.InputBox("Введите число", ""));
            string eightNum = Convert.ToString(Convert.ToInt32(Convert.ToString(num), 10), 8);
            MessageBox.Show("Вторая справа цифра в восьмеричном представлении числа: " + eightNum[eightNum.Length - 2], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
