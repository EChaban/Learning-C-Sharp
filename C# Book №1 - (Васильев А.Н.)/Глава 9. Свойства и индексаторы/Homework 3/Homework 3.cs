/*Напишите программу, в которой есть класс с целочисленным массивом.
Опишите в классе свойство, доступное только для считывания значения.
Значением свойства является сумма элементов массива.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class MyClass
    {
        private int[] myArray = { 1, 2, 3, 4, 5, 6 };

        public int MyProperty
        {
            get{ return myArray.Sum(); }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.MyProperty);
        }
    }
}
