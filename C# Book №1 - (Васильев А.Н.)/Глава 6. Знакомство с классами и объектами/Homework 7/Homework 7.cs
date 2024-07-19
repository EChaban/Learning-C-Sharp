/*Напишите программу с классом, в котором есть два поля: символьное и текстовое. 
В классе должен быть перегруженный метод для присваивания значений полям. 
Если метод вызывается с символьным аргументом, то соответствующее значение присваивается символьному полю. 
Если метод вызывается с текстовым аргументом, то он определяет значение текстового поля. 
Методу аргументом также может передаваться символьный массив. 
Если массив состоит из одного элемента, то он определяет значение символьного поля. 
В противном случае (если в массиве больше одного элемента) из символов массива 
формируется текстовая строка и присваивается значением текстовому полю.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        class Text
        {
            char symbol;
            string line;

            public void Set(char symbol)
            {
                this.symbol = symbol;
            }

            public void Set(string line)
            {
                this.line = line;
            }

            public void Set(char symbol, string line)
            {
                this.symbol = symbol;
                this.line = line;
            }

            public void Set(char[] array)
            {
                if (array.Length == 1)
                {
                    symbol = array[0];
                }
                else
                {
                    line = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        line += array[i];
                    }
                }
            }

            public void WriteText()
            {
                Console.WriteLine(symbol + ", " + line);
            }
        }
        static void Main(string[] args)
        {
            Text text = new Text();
            Console.WriteLine("Помещаем в объект символ \'a\'");
            text.Set('a');
            Console.Write("Результат: ");
            text.WriteText();
            Console.WriteLine();

            Console.WriteLine("Помещаем в объект строку \"си-шарп\"");
            text.Set("си-шарп");
            Console.Write("Результат: ");
            text.WriteText();
            Console.WriteLine();

            Console.WriteLine("Помещаем в объект символ \'B\' и строку \"С#\"");
            text.Set('B', "С#");
            Console.Write("Результат: ");
            text.WriteText();
            Console.WriteLine();

            char[] chars = { 'c' };
            Console.WriteLine("Помещаем в объект массив ['c']");
            text.Set(chars);
            Console.Write("Результат: ");
            text.WriteText();
            Console.WriteLine();

            char[] chars2 = { 'c', '-', 's', 'h', 'a', 'r', 'p'};
            Console.WriteLine("Помещаем в объект массив ['c', '-', 's', 'h', 'a', 'r', 'p']");
            text.Set(chars2);
            Console.Write("Результат: ");
            text.WriteText();
            Console.WriteLine();
        }
    }
}
