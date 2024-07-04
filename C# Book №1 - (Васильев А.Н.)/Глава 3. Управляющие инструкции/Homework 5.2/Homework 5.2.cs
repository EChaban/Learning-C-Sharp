/*Напишите программу, в которой пользователю предлагается ввести
название дня недели. По введенному названию программа определяет
порядковый номер дня в неделе. Если пользователь вводит неправильное
название дня, программа выводит сообщение о том, что такого дня
нет. Предложите версию программы на основе вложенных условных
операторов и на основе оператора выбора switch.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_5._2
{
    internal static class Program
    {
        static void Main()
        {
            string dayOfWeek = Interaction.InputBox("Введите один из параметров:\nmon, tue, wed, thu, fri, sat, sun.", "Ввод параметра");
            switch (dayOfWeek)
            {
                case "mon":
                    MessageBox.Show("Порядковый номер дня недели: 1", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "tue":
                    MessageBox.Show("Порядковый номер дня недели: 2", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "wed":
                    MessageBox.Show("Порядковый номер дня недели: 3", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "thu":
                    MessageBox.Show("Порядковый номер дня недели: 4", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "fri":
                    MessageBox.Show("Порядковый номер дня недели: 5", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "sat":
                    MessageBox.Show("Порядковый номер дня недели: 6", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "sun":
                    MessageBox.Show("Порядковый номер дня недели: 7", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Параметр введён не верно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }    
        }
    }
}
