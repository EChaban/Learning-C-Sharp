/* Напишите программу, в которой пользователь вводит сначала имя,
а затем фамилию. Программа выводит сообщение с информацией
об имени и фамилии пользователя. Предложите версию программы,
в которой ввод и вывод текста осуществляется с помощью диалоговых окон. */

using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace Homework_1
{
    internal static class Program
    {
        static void Main()
        {
            string name, surname;
            name = Interaction.InputBox("Введите ваше имя?", "Имя");
            surname = Interaction.InputBox("Введите вашу фамилию?", "Фамилия");
            MessageBox.Show("Приятно познакомится " + name + " " + surname + "!", "Приятно познакомится!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
