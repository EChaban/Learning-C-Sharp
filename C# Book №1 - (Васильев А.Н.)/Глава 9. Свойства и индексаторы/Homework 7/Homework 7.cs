/*Напишите программу с классом, в котором есть неотрицательное целочисленное
поле. Опишите для класса индексатор (с одним get-аксессором)
такой, что при индексировании объекта с целочисленным индексом
результатом возвращается значение бита в бинарном представлении
числа (значение целочисленного поля).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        class MyClass
        {
            private uint num;

            public MyClass(uint num) { this.num = num; }

            public uint this[int i]
            {
                get
                {
                    string binary = Convert.ToString(num, 2);
                    if (i >= 0 && i <= binary.Length - 1) return Convert.ToUInt32(Convert.ToString(binary[i]));
                    else return Convert.ToUInt32(Convert.ToString(binary[binary.Length - 1]));
                }
            }
        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass(199);
            Console.WriteLine("Двоичный код числа 199: " + Convert.ToString(199, 2));

            Console.WriteLine("Поочерёдно получаем индексы бинарного представления числа 199: ");
            for (int i = 0; i < 10;  i++)
            {
                Console.Write(obj[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
