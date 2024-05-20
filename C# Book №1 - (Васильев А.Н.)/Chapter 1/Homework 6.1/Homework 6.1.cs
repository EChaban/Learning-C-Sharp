/* Напишите программу, в которой пользователь водит имя и год рождения,
а программа отображает сообщение, содержащее имя пользователя
и его возраст. Предложите версию программы, в которой ввод и вывод данных 
выполняется с помощью диалоговых окон. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_6._1
{
    internal static class Program
    {
        static void Main()
        {
            string name = Interaction.InputBox("Введите имя", "Имя");
            int yearOfBirth = Convert.ToInt32(Interaction.InputBox("Введите год рождения", "Год рождения"));
            MessageBox.Show(name + " " + (DateTime.Now.Year - yearOfBirth) + " лет", "Данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
