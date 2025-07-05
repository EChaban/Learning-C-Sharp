/*Напишите программу, в которой на основе класса ArrayList созда-
ется коллекция и заполняется текстовыми элементами. Текстовые зна-
чения — это слова из текста, записанного в текстовую переменную. Ис-
ходите из того, что слова в тексте разделяются пробелами.*/

using System;
using System.Collections;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это текстовая переменная где слова разделяются пробелами.";

            string[] wordsArray = text.Split(new[] { ' ' });
            ArrayList list = new ArrayList(wordsArray);

            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
