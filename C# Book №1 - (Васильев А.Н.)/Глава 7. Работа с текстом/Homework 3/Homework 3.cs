/*Напишите программу со статическим методом для сравнения текстовых
строк. Строки на предмет совпадения сравниваются посимвольно.
Правило сравнения символов такое: два символа считаются одинаковыми,
если их коды отличаются не больше, чем на единицу. Текстовые строки
совпадают, если у них совпадают символы (в указанном выше смысле).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void EqualityStrings(params string[] texts)
        {
            string result = "Равны";
            for (int i = 0; i < texts.Length - 1; i++)
            {
                if (texts[i].Length != texts[i + 1].Length)
                {
                    result = "Не равны";
                    break;
                }
                for (int j = 0; j < texts[i].Length; j++)
                {
                    if (texts[i][j] != texts[i + 1][j] && texts[i][j] + 1 != texts[i + 1][j] && texts[i][j] - 1 != texts[i + 1][j])
                    {
                        result = "Не равны";
                        goto label;
                    }
                }
            }
            label:
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string a, b, c;
            a = "abcd";
            b = "bcde";
            c = "cdef";
            EqualityStrings(a, b, c);

            a = "abcd";
            b = "bcdef";
            c = "cdef";
            EqualityStrings(a, b, c);

            a = "abcd";
            b = "bcde";
            c = "cdej";
            EqualityStrings(a, b, c);
        }
    }
}
