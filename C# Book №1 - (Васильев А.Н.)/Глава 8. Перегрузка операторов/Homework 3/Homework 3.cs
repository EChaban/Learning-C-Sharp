/*Напишите программу, в которой есть класс с двумя целочисленными
полями. Опишите для этого класса операторные методы, которые позволяют
сравнивать объекты класса на предмет «меньше» или «больше» .
Исходите из того, что один объект меньше/больше другого, если сумма
квадратов значений его полей меньше/больше суммы квадратов значений
полей другого объекта.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class MyClass
    {
        public int num1;
        public int num2;

        public MyClass(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public static bool operator >(MyClass obj1, MyClass obj2)
        {
            int sumPow1 = (int)(Math.Pow(obj1.num1, 2) + (int)Math.Pow(obj1.num2, 2));
            int sumPow2 = (int)(Math.Pow(obj2.num1, 2) + (int)Math.Pow(obj2.num2, 2));

            if (sumPow1 > sumPow2) return true;
            else return false;
        }

        public static bool operator <(MyClass obj1, MyClass obj2)
        {
            if(obj1 > obj2) return false;
            else return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(5, 10);
            MyClass obj2 = new MyClass(15, 30);

            Console.WriteLine("obj1.num1 = " + obj1.num1 + ", obj1.num2 = " + obj1.num2);
            Console.WriteLine("obj2.num1 = " + obj2.num1 + ", obj2.num2 = " + obj2.num2);

            Console.WriteLine();

            Console.WriteLine("obj1 > obj2: " + (obj1 > obj2));
            Console.WriteLine("obj1 < obj2: " + (obj1 < obj2));
        }
    }
}
