/*Напишите программу, в которой для введенного пользователем числа
в бинарном представлении четвертый бит устанавливается равным
нулю.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(num, 2);
            if (binaryNum.Length >= 4)
            {
                char[] binaryChar = binaryNum.ToCharArray();
                binaryChar[3] = '0';
                binaryNum = String.Concat<char>(binaryChar);
                binaryNum = Convert.ToString(Convert.ToInt32(binaryNum, 2), 10);
                Console.WriteLine(binaryNum);
            }
            else Console.WriteLine(num);
        }
    }
}
