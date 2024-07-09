/*Напишите программу, в которой создается одномерный символьный массив из 10 элементов. 
Массив заполняется буквами "через одну". 
Начиная с буквы ' а ' : то есть массив заполняется буквами 'а' ,'с' ,'е' ,'g' и так далее. 
Отобразите массив в консольном окне в прямом и обратном порядке. Размер массива задается переменной.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            char firstElement = 'a';
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = firstElement;
                firstElement = Convert.ToChar(firstElement + 2);
            }
            foreach (char c in chars) Console.Write(c + " ");
            Console.WriteLine();
            for (int i = chars.Length - 1; i >= 0; i--) Console.Write(chars[i] + " ");
        }
    }
}
