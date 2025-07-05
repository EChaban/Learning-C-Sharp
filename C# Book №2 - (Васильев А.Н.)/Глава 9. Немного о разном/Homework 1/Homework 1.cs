/*Напишите программу, в которой генерируется случайное целое чис-
ло (например, в диапазоне от 1 до 10), а пользователю необходимо его
угадать. Если пользователь не угадал число, программа выдает запрос
о том, хочет ли он попробовать еще раз. Процесс заканчивается, если
пользователь угадывает число или отказывается угадывать снова. Для
ввода чисел использовать окно с полем ввода, а для запроса о желании
продолжить угадывание использовать окно с кнопками Да и Нет.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Homework_1
{
    class MyClass
    {
        Random rnd = new Random();
        public void Run()
        {
            int num = rnd.Next(1, 11);
            DialogResult answer = DialogResult.Yes;

            while (answer == DialogResult.Yes)
            {
                int numForCompare = int.Parse(Interaction.InputBox("Отгадайте число от 1 до 10", "Ввод числа"));

                if (numForCompare != num)
                    answer = MessageBox.Show("Вы не отгадали число.\nХотите попробовать снова?", "Число не отгадано", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else {
                    MessageBox.Show($"Вы отгадали, это число {num}", "Верно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Run();
        }
    }
}
