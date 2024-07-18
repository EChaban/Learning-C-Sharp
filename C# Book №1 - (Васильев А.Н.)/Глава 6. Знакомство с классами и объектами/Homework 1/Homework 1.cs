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
    class SymbolInfo
    {
        char symbol;

        public void Set(char symbol)
        {
            this.symbol = symbol;
        }

        public int GetCode()
        {
            return Convert.ToInt32(symbol);
        }

        public void GetInfo()
        {
            Console.WriteLine(symbol);
            int symCode = GetCode();
            Console.WriteLine(symCode);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SymbolInfo symbolInfo = new SymbolInfo();
            Console.WriteLine("Помещаем в \"symbol\" - \'b\'");
            symbolInfo.Set('b');

            Console.WriteLine("Вызываем метод \"GetCode\": " + symbolInfo.GetCode());

            Console.WriteLine("Вызываем метод \"GetInfo\":");
            symbolInfo.GetInfo();
        }
    }
}
