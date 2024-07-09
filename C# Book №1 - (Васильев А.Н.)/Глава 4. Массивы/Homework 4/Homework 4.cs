/*Напишите программу, в которой создается символьный массив
из 10 элементов. Массив заполнить большими (прописными) буквами
английского алфавита. Буквы берутся подряд, но только согласные
(то есть гласные буквы 'А', 'Е' и 'I' при присваивании значений элементам
массива нужно пропустить). Отобразите содержимое созданного
массива в консольном окне.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[10];
            char firstElmenet = 'A';

            for (int i = 0; i < chars.Length; i++)
            {
                while (true)
                {
                    if (firstElmenet == 'A' || firstElmenet == 'E' || firstElmenet == 'I')
                    {
                        firstElmenet = Convert.ToChar(firstElmenet + 1);
                    }
                    else
                    {
                        chars[i] = firstElmenet;
                        firstElmenet = Convert.ToChar(firstElmenet + 1);
                        break;
                    }
                }
            }

            foreach (char c in chars) Console.Write(c + " ");
        }
    }
}
