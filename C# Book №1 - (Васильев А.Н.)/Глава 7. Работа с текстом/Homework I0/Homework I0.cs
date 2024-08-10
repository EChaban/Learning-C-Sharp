/*Напишите программу с классом, у которого есть поле, являющееся
ссылкой на целочисленный массив. При создании объекта массив
заполняется случайными числами. Переопределите в классе метод
ToString() так, чтобы метод возвращал текстовую строку со значениями
элементов массива. Также строка должна содержать информацию
о количестве элементов массива и среднем значении для элементов массива
(сумма значений элементов, деленная на количество элементов).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    class ParseArray
    {
        int[] ints;

        public ParseArray()
        {
            Random rnd = new Random();

            ints = new int[rnd.Next(21)];
            for (int i = 0; i < ints.Length; i++)
                ints[i] = rnd.Next(101);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < ints.Length; i++)
                result += ints[i] + " ";
            result += "\n" + "Number of array elements: " + ints.Length + "\n" + "Arithmetic mean: " + (ints.Sum() / ints.Length);
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ParseArray obj = new ParseArray();
            Console.WriteLine(obj);
        }
    }
}
