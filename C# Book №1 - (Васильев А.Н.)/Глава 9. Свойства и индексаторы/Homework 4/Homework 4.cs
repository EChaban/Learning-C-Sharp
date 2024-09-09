/*Напишите программу, в которой есть класс с закрытым неотрицательным
целочисленным полем. Также в классе должно быть закрытое
текстовое поле, содержащее значением восьмеричный код числа из целочисленного
поля. Опишите в классе свойство, доступное только для
присваивания значения. При присваивании неотрицательного целочисленного
значения свойству соответствующее число записывается в целочисленное
поле, а в текстовое поле заносится восьмеричный код числа.
Опишите еще одно свойство, доступное только для чтения, которое
результатом возвращает текст из текстового поля (восьмеричный код
числа).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        class MyClass
        {
            private uint num;
            private string eightBit;

            public int SetProperty
            {
                set
                {
                    num = (uint)value;
                    eightBit = Convert.ToString(num, 8);
                }
            }

            public string GetProperty
            {
                get { return eightBit; }
            }
        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.SetProperty = 55;
            Console.WriteLine("We should get 67");
            Console.WriteLine("Result: " + obj.GetProperty);
        }
    }
}
