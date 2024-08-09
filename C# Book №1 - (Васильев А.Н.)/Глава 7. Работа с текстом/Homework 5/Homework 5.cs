/*Напишите программу со статическим методом, определяющим позиции,
на которых в тексте находится определенный символ. Аргументами
методу передаются текст и символ. Результатом метод возвращает целочисленный
массив, значения элементов которого - это индексы позиций,
на которых символ (второй аргумент) находится в тексте (первый
аргумент). Если символ в тексте не встречается, то метод результатом
возвращает массив из одного элемента, значение которого равно - 1 .*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static int[] FindIndexes(string text, char sym)
        {
            int[] result;
            string indexes = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == sym) indexes += (i + ",");
            }

            if (indexes.Length < 1) 
            {
                result = new int[]{ -1};
                return result;
            }

            indexes = indexes.Remove(indexes.Length - 1);

            string[] indexesArray = indexes.Split(',');
            result = new int[indexesArray.Length];
            for (int i = 0; i < indexesArray.Length; i++)
            {
                result[i] = Convert.ToInt32(indexesArray[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string text = "ajbcdefj";
            char sym = 'j';
            int[] indexes = FindIndexes(text, sym);
            foreach (int i in indexes)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
