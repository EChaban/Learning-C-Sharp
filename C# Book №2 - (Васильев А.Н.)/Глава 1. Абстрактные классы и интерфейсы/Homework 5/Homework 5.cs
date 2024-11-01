/*Напишите программу, содержащую два интерфейса. В первом ин-
терфейсе опишите метод с символьным аргументом и целочислен-
ным результатом, а во втором интерфейсе — метод с целочисленным
аргументом и символьным результатом. Опишите класс, реализующий
оба интерфейса. Проверьте работу методов, вызвав их через объектную
переменную и через интерфейсные переменные (там, где это возможно).*/

using System;

namespace Homework_5
{
    interface IReturnInt
    {
        int Return(char symb);
    }

    interface IReturnChar
    {
        char Return(int num);
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

        public int Return(char symb)
        {
            return num;
        }

        public char Return(int num)
        {
            return symb;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5, 'a');
            IReturnInt returnInt = obj;
            IReturnChar returnChar = obj;
            Console.WriteLine($"MyClass {obj.Return('a')}");
            Console.WriteLine($"MyClass {obj.Return(5)}");
            Console.WriteLine($"IReturnInt {returnInt.Return('a')}");
            Console.WriteLine($"IReturnChar {returnChar.Return(5)}");
        }
    }
}
