/*Напишите программу с классом, у которого есть два целочисленных
поля. В классе должны быть описаны конструкторы, позволяющие создавать
объекты без передачи аргументов, с передачей одного аргумента
и с передачей двух аргументов.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class TwoInts
    {
        int a, b;
        public TwoInts()
        {
            Console.WriteLine("Создан объект без передачи аргументов.");
        }

        public TwoInts(int a)
        {
            this.a = a;
            Console.WriteLine("Создан объект c передачей одного аргумента.");
        }
        public TwoInts(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Создан объект c передачей двух аргумента.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoInts twoInts = new TwoInts();
            TwoInts twoInts2 = new TwoInts(5);
            TwoInts twoInts3 = new TwoInts(1, 2);

        }
    }
}
