/* Напишите программу, в которой есть класс с целочисленным массивом
и целочисленным свойством. При считывании значения свойства
оно последовательно и циклически возвращает значения элементов массива.
При присваивании значения свойству изменяется значение того
элемента, который в данный момент интерпретируется как значение
свойства. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class MyClass
    {
        private int[] myArray;
        private int count = 0;

        public MyClass(int[] myArray)
        {
            this.myArray = myArray;
        }

        public int MyProperty
        {
            get {
                int result = myArray[count];
                count = ++count % myArray.Length;
                return result;
            }

            set { myArray[count] = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5};
            MyClass obj = new MyClass(myArray);

            Console.WriteLine(obj.MyProperty);
            Console.WriteLine(obj.MyProperty);
            obj.MyProperty = 30;
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine(obj.MyProperty);
            obj.MyProperty = 50;
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine();
            Console.WriteLine(obj.MyProperty);
            obj.MyProperty = 20;
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine(obj.MyProperty);
            obj.MyProperty = 40;
            Console.WriteLine(obj.MyProperty);
            Console.WriteLine(obj.MyProperty);
        }
    }
}
