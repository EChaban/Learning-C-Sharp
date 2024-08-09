/*Напишите программу, в которой есть статический метод, возвращающий
результатом текстовое значение и получающий аргументом текст.
Результат метода - это переданный аргументом текст, в котором слова
следуют в обратном порядке. Словами считать блоки текста, разделенные
пробелами.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static string ReverseText(string text)
        {
            string[] textArray = text.Split(' ');
            text = "";
            for (int i = textArray.Length - 1; i >= 0; i--)
                text += (textArray[i] + " ");
            text.Remove(text.Length - 1);
            return text;
        }

        static void Main(string[] args)
        {
            string text = "Hello everyone I am learning C#";
            Console.WriteLine(ReverseText(text));
        }
    }
}
