/*Напишите программу с классом, в котором есть закрытое символьное
поле и три открытых метода. Один из методов позволяет присвоить
значение полю. Еще один метод при вызове возвращает результатом
код символа. Третий метод позволяет вывести в консольное окно символ
(значение поля) и его код.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class DataChar
    {
        char symbol;
        public void Set(char symbol)
        {
            this.symbol = symbol;
        }

        public int GetCode()
        {
            return int.Parse(symbol);
        }

        public void GetDate()
        {
            Console.WriteLine("Символ: " + symbol);
            Console.WriteLine("Код символа: " + GetCode);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Присвоение значение полю \"symbol\": b");
            DataChar sym = new DataChar();
            sym.Set('b');
            Console.WriteLine((string)"Проверка значения в полюе:" + Convert.ToString(Convert.ToChar(sym.GetCode)));
            Console.WriteLine("Вызов метода GetCode: " + Convert.ToString(sym.GetCode));
            Console.WriteLine("Вызов метода GetDate: " + Convert.ToString(sym.GetDate));

        }
    }
}
