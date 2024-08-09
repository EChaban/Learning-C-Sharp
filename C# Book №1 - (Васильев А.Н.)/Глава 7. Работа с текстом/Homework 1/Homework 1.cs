/*Напишите программу, в которой есть статический метод. Аргументом
методу передается текстовое значение. Результатом метод возвращает
текст, в котором, по сравнению с текстом-аргументом, между символами
вставлены пробелы.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static string NewText(string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length - 1; i++)
            {
                newText += (text[i] + " ");
            }
            return newText;
        }

        static void Main(string[] args)
        {
            string text = "Hello!";
            Console.WriteLine(NewText(text));
        }
    }
}
