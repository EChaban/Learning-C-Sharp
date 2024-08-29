/*Напишите программу, в которой есть класс с целочисленным полем.
Перегрузите операторы &, |, true и false так, чтобы с объектами класса
можно бьшо использовать операторы && и ||. Перегрузку следует реализовать
так, чтобы объект считался «истинным» , если значение его
числового поля равно 2, 3, 5 или 7 . Объект должен рассматриваться как
«ложный» , если значение его числового поля меньше 1 или больше 1О.*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class MyClass
    {
        public int num;

        public MyClass(int n)
        {
            num = n;
        }

        public static MyClass operator &(MyClass obj1, MyClass obj2)
        {
            if (obj1) return obj2;
            else return obj1;
        }

        public static MyClass operator |(MyClass obj1, MyClass obj2)
        {
            if (obj1) return obj1;
            else return obj2;
        }

        public static bool operator true(MyClass obj)
        {
            switch (obj.num)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator false(MyClass obj)
        {
            if(obj.num < 1 || obj.num > 10) return false;
            else return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(5);
            MyClass obj2 = new MyClass(11);

            Console.WriteLine("true is 2, 3, 5, 7");
            Console.WriteLine("false is 1 < num > 10");
            Console.WriteLine("obj1.num: " + obj1.num);
            Console.WriteLine("obj2.num: " + obj2.num);
            Console.WriteLine();

            bool value;
            bool value2;

            if (obj1) value = true;
            else value = false;
            Console.WriteLine("obj1: " + value);

            if (obj2) value2 = true;
            else value2 = false;
            Console.WriteLine("obj2: " + value2);

            Console.WriteLine("obj1 & obj2: " + (value & value2));
            Console.WriteLine("obj1 && obj2: " + (value && value2));
            Console.WriteLine("obj1 | obj2: " + (value | value2));
            Console.WriteLine("obj1 || obj2: " + (value || value2));
        }
    }
}
