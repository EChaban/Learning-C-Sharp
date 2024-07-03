/*Напишите программу, в которой для введенного пользователем числа
в бинарном представлении третий бит устанавливается равным единице.*/

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace Homework_8
{
    internal static class Program
    {
        static void Main()
        {
            string num = Interaction.InputBox("Введите число", "");
            string binaryNum = Convert.ToString(Convert.ToInt32(num, 10), 2);
            char[] binaryChar = binaryNum.ToCharArray();
            binaryChar[2] = '1';
            binaryNum = String.Concat<char>(binaryChar);
            num = Convert.ToString(Convert.ToInt32(binaryNum, 2), 10);
            MessageBox.Show(num, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
