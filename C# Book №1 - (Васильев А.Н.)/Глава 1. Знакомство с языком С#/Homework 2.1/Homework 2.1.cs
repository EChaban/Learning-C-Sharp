/* Напишите программу, в которой пользователь вводит имя и возраст.
Программа отображает сообщение об имени и возрасте пользователя.
Предложите версию, в которой данные вводятся и выводятся с помощью диалоговых окон. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_1
{
    internal static class Program
    {
        static void Main()
        {
            int nowYear = Convert.ToInt32(DateTime.Now.Year);
            string name = Interaction.InputBox("Как вас зовут?", "Имя");
            int age = Convert.ToInt32(Interaction.InputBox("Сколько вам исполняется/исполнилось в этом году?", "Возраст"));
            age = nowYear - age; 
            MessageBox.Show("Ваши данные: " + name + " " + age + " " + "года рождения.", "Данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
