/*Напишите программу со статическим методом, который эмулирует
работу метода Substring() . Аргументами статическому методу передается
текст и два целочисленных аргумента. Результатом метод возвращает
текстовую строку, которая состоит из символов текста (первый
аргумент), начиная с позиции с индексом, определяемым вторым аргументом
метода. Третий аргумент статического метода определяет количество
символов, которые включаются в подстроку.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static string newSubstring(string text, int startIndex, int countSymbs)
        {
            string newText = "";
            for (int i = startIndex; i < startIndex + countSymbs; i++)
            {
                newText += text[i];
            }
            return newText;
        }

        static void Main(string[] args)
        {
            string text = "Learning C#";
            text = newSubstring(text, 2, 6);
            Console.WriteLine(text);
        }
    }
}
