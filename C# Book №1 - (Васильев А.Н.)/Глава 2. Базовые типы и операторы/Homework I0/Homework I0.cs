/*Напишите программу, в которой для введенного пользователем числа
в бинарном представлении значение второго бита меняется на противоположное
(исходное нулевое значение бита меняется на единичное,
а исходное единичное значение бита меняется на нулевое).*/

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Homework_I0
{
    internal static class Program
    {
        static void Main()
        {
            int num = int.Parse(Interaction.InputBox("Введите число", ""));
            List<char> binaryNum = new List<char>(Convert.ToString(num, 2));
            binaryNum[1] = binaryNum[1]  == '1' ? '0' : '1';
            string binaryString = String.Concat<char>(binaryNum);
            string result = Convert.ToString(Convert.ToInt32(binaryString, 2), 10);
            MessageBox.Show("Число после побитовой инверсии " + result, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
