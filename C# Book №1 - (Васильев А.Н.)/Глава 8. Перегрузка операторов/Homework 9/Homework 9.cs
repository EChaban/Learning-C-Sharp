/*Напишите программу, в которой есть класс с целочисленным полем
и перегрузкой операторов +, - и *. Предложите такой способ перегрузки
этих операторов, чтобы с объектами класса можно бьшо использовать
операторы +=, -= и *=. */

using System;
using System.Runtime.CompilerServices;

namespace Homework_9
{
    class MyClass
    {
        public int num;

        public MyClass(int n)
        {
            num = n;
        }

        public static MyClass operator +(MyClass a, MyClass b)
        {
            return new MyClass(a.num + b.num);
        }

        public static MyClass operator -(MyClass a, MyClass b)
        {
            return new MyClass(a.num - b.num);
        }

        public static MyClass operator *(MyClass a, MyClass b)
        {
            return new MyClass(a.num * b.num);
        }

        public static implicit operator MyClass(int n)
        {
        return new MyClass(n); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(5);
            MyClass b = new MyClass(7);

            Console.WriteLine(a.num + " " + b.num);
            a += b;
            Console.WriteLine(a.num + " " + b.num);
            b *= a;
            Console.WriteLine(a.num + " " + b.num);
            b -= a;
            Console.WriteLine(a.num + " " + b.num);
        }
    }
}
