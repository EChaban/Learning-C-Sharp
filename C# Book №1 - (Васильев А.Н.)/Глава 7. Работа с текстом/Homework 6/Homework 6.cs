/*Напишите программу со статическим методом, аргументом которому
передается текст, а результатом возвращается символьный массив, состоящий
из букв (без учета пробелов и знаков препинания), из которых
состоит текст. Если буква несколько раз встречается в тексте, в массиве
она представлена одним элементом. Буквы в массиве-результате должны
быть отсортированы в алфавитном порядке.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static char[] SortChars(string text)
        {
            char[] trimSymbs = { ' ', '.', ',', '!', '?', '-', ';', ':', '"', '\''};
            for (int i = 0; i < trimSymbs.Length; i++)
            {
                for (int j = 0; j < text.Length;)
                {
                    if (trimSymbs[i] == text[j])
                        text = text.Remove(j, 1);
                    else j++;
                }
            }

            string newText = "";

            while (text.Length > 0)
            {
                char sym = text[0];
                newText += sym;
                for (int i = 0; i < text.Length;)
                {
                    if (text[i] == sym)
                        text = text.Remove(i, 1);
                    else i++;
                }
            }

            char[] result = newText.ToCharArray();
            Array.Sort(result);
            return result;
        }

        static void Main(string[] args)
        {
            string text = "Hello everyone. I'm practicing programming here.";
            char[] symbs = SortChars(text);
            foreach (char c in symbs)
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
