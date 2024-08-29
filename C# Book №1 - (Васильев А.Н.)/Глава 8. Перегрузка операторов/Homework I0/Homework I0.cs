/*Напишите программу, в которой есть класс с символьным полем
и перегрузкой операторов + и -. Операторы должны быть перегружены
так, чтобы применение оператора + к объектам класса давало результатом
текст, получающийся объединением значений символьных полей
суммируемых объектов. При применении оператора - к объектам класса
результатом должно возвращаться целое число (разность кодов символов
из вычитаемых объектов). Предложите такие способы перегрузки
операторов приведения типа, чтобы с объектами класса можно было использовать
операторы += и -= .*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    class MyClass
    {
        public char symb;

        public MyClass(char symb)
        {
            this.symb = symb;
        }

        public static string operator +(MyClass a, MyClass b)
        {
            string text = "";
            text += a.symb;
            text += b.symb;
            return text;
        }

        public static int operator -(MyClass a, MyClass b)
        {
            int num = a.symb - b.symb;
            return num;
        }

        public static implicit operator MyClass(string str)
        {
            MyClass obj = new MyClass('z');
            return obj;
        }

        public static implicit operator MyClass(int num)
        {
            MyClass obj = new MyClass('z');
            return obj;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass('a');
            MyClass b = new MyClass('b');
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            a += b;
            Console.WriteLine(a.symb);
            b -= a;
            Console.WriteLine(b.symb);
        }
    }
}
