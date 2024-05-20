/* Напишите программу, в которой по возрасту определяется год рождения.
Возраст пользователь вводит в окно с полем, а вычисленный год
рождения отображается в другом диалоговом окне. */

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_7._1
{
    internal static class Program
    {
        static void Main()
        {
            int age = int.Parse(Interaction.InputBox("Введите ваш возраст",""));
            Interaction.InputBox("Ваш год рождения" + (DateTime.Now.Year - age), "");
        }
    }
}
