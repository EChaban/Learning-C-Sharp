/*Напишите программу, которая вычисляет третий бит справа в двоичном
представлении числа, введенного пользователем. Число вводится
в десятичном (обычном) представлении. В программе используйте оператор
побитового сдвига.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int num = int.Parse(Console.ReadLine());
            num = num >> 2;
            string binaryNum = Convert.ToString(Convert.ToInt32(Convert.ToString(num), 10), 2);
            Console.WriteLine(binaryNum[binaryNum.Length - 1]);
        }
    }
}
