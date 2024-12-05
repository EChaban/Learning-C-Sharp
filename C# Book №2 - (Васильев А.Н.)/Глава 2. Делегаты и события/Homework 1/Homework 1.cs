/*Напишите программу, в которой объявляется делегат для методов
с двумя аргументами (символ и текст) и целочисленным результатом.
В главном классе необходимо описать два статических метода. Один
статический метод результатом возвращает количество вхождений сим-
вола (первый аргумент) в текстовую строку (второй аргумент). Другой
метод результатом возвращает индекс первого вхождения символа (пер-
вый аргумент) в текстовую строку (второй аргумент) или значение -1,
если символ в текстовой строке не встречается. В главном методе со-
здать экземпляр делегата и с помощью этого экземпляра вызвать каж-
дый из статических методов.*/

using System;
using System.Linq;

namespace Глава_2.Делегаты_и_события
{
    delegate int TestDelegate(char symb, string text);

    internal class Program
    {
        static int CountSymbs(char symb, string text)
        {
            return text.Count(s => s == symb);
        }

        static int FirstSymb(char symb, string text)
        {
            return text.IndexOf(symb);
        }

        static void Main(string[] args)
        {
            TestDelegate delegat = new TestDelegate(CountSymbs);
            Console.WriteLine(delegat('a', "ababab"));
            delegat = FirstSymb;
            Console.WriteLine(delegat('b', "ababab"));
        }
    }
}