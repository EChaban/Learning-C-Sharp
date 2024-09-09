/*Напишите программу, в которой есть класс с символьным свойством.
Опишите аксессоры для свойства так, чтобы значение свойства попадало
в диапазон символов от 'А' до 'z' включительно.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class MyClass
    {
        private char myVar;

        public char MyProperty
        {
            get {
                if (myVar < 'A') myVar = 'A';
                if (myVar > 'Z' && myVar < 'a') myVar = 'a';
                if (myVar > 'z') myVar = 'z';
                return myVar; 
            }
            set {
                if (value < 'A') myVar = 'A';
                if (value > 'Z' && value < 'a') myVar = 'a';
                if (value > 'z') myVar = 'z';
                myVar = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.MyProperty = 'b';
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine((int)obj.MyProperty);
            Console.WriteLine();

            obj.MyProperty = 'B';
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine((int)obj.MyProperty);
            Console.WriteLine();

            Console.WriteLine('$');
            Console.WriteLine((int)'$');
            Console.WriteLine();

            obj.MyProperty = '$';
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine((int)obj.MyProperty);
            Console.WriteLine();

            Console.WriteLine('`');
            Console.WriteLine((int)'`');
            Console.WriteLine();

            obj.MyProperty = '`';
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine((int)obj.MyProperty);
            Console.WriteLine();

            Console.WriteLine('ж');
            Console.WriteLine((int)'ж');
            Console.WriteLine();

            obj.MyProperty = 'ж';
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine((int)obj.MyProperty);
            Console.WriteLine();
        }
    }
}
