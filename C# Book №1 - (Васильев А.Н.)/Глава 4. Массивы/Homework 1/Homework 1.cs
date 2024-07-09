/*Напишите программу, в которой создается одномерный числовой массив
и заполняется числами, которые при делении на 5 дают в остатке 2
(числа 2 ,7 ,12 ,17 и так далее) . Размер массива вводится пользователем.
Предусмотреть обработку ошибки, связанной с вводом некорректного
значения.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Label:
            try
            {
                Console.Write("Введите размер массива: ");
                int size = int.Parse(Console.ReadLine());
                int[] nums = new int[size];
                int count = 0;

                for (int i = 1; count < size; i++)
                {
                    if (i % 5 == 2)
                    {
                        nums[count] = i;
                        count++;
                    }
                }

                foreach (int i in nums) Console.Write(i + " ");
            }
            catch
            {
                Console.WriteLine("Размер массива введен некорректно");
                goto Label;
            }
            
        }
    }
}
