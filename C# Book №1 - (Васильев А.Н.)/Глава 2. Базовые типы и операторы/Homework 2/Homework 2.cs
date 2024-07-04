/*Напишите программу, которая проверяет, удовлетворяет ли введенное
пользователем число следующим критериям: при делении на 5 в остатке
получается 2, а при делении на 7 в остатке получается 1 .*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_2
{
    internal static class Program
    {
        static void Main()
        {
            int num = int.Parse(Interaction.InputBox("Введите число", "Введите число"));
            if (num % 5 == 2 &&  num % 7 == 1) MessageBox.Show("При дилении на 5, в остатке получаем 2. \nПри дилении на 7, в остатке 1.", "Число верное!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("Не соответсвует критериям: \nПри дилении на 5, в остатке получаем 2. \nПри дилении на 7, в остатке 1.", "Число не верное!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
