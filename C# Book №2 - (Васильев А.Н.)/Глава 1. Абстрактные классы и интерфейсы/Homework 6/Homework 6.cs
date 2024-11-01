/*Напишите программу, в которой на основе двух интерфейсов созда-
ется класс. В одном интерфейсе объявлен индексатор с символьным ин-
дексом, возвращающий целочисленное значение. В другом интерфейсе
объявлен индексатор с целочисленным индексом, возвращающий сим-
вольное значение.*/

using System;

namespace Homework_6
{
    interface IReturnInt
    {
        int this[char symb]
        {
            get;
        }
    }

    interface IReturnChar
    {
        char this[int num]
        {
            get;
        }
    }

    class MyClass : IReturnInt, IReturnChar
    {
        int num;
        char symb;

        public MyClass(int num, char symb)
        {
            this.num = num;
            this.symb = symb;
        }

        public int this[char symb]
        {
            get { return num; }
        }

        public char this[int num]
        {
            get { return symb; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5, 'a');
            IReturnInt returnInt = obj;
            IReturnChar returnChar = obj;
            Console.WriteLine(obj['a']);
            Console.WriteLine(obj[5]);
            Console.WriteLine(returnInt['a']);
            Console.WriteLine(returnChar[5]);
        }
    }
}
