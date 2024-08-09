/*Напишите программу со статическим методом, который выполняет
сравнение текстовых строк. Текстовые строки сравниваются следующим
образом: для каждого текстового значения определяется набор разных
букв, входящих в текст (при этом количество вхождений буквы в текст
значения не имеет). Текстовые строки считаются равными, если они содержат
одинаковые наборы букв.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void EqualityStrings(params string[] texts)
        {
            string[] newTexts = new string[texts.Length];

            for (int i = 0; i < texts.Length; i++)
            {
                while (texts[i].Length > 0)
                {
                    newTexts[i] += texts[i][0];
                    texts[i] = texts[i].Trim(texts[i][0]);
                }
                char[] chars = newTexts[i].ToCharArray();
                Array.Sort(chars);
                newTexts[i] = String.Concat<char>(chars);
            }

            string result = "Равны";
            for (int i = 0; i < newTexts.Length - 1; i++)
            {
                for (int j = i + 1; j < newTexts[i].Length; j++)
                {
                    if (newTexts[i] != newTexts[j])
                    {
                        result = "Не равны";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string a, b, c;
            a = "abbc";
            b = "baaccc";
            c = "cbbaa";
            EqualityStrings(a, b, c);

            a = "abbc";
            b = "baac";
            c = "cbbag";
            EqualityStrings(a, b, c);
        }
    }
}
