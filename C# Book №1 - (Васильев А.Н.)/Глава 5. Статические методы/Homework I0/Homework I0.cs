/*Напишите программу со статическим методом, которому передается
текст и произвольное количество символьных аргументов. Результатом
возвращается текст, который получается добавлением в конец исходного
текста (первый аргумент метода) символьных значений, переданных
аргументами методу.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    internal class Program
    {
        static string ConcatText(string text, params char[] chars)
        {
            string text2 = String.Concat<char>(chars);
            return text + text2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConcatText("Text", ' ', 't', 'e', 'x', 't'));
        }
    }
}
