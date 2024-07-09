/*Напишите программу, в которой создается символьный массив, а затем
порядок элементов в массиве меняется на обратный.*/

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
            int size = 'Z'- 'A' + 1;
            char firstElemet = 'A';
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = firstElemet;
                firstElemet++;
            }

            Array.Reverse(chars);

            foreach (char c in chars) Console.Write(c + " ");
        }
    }
}
