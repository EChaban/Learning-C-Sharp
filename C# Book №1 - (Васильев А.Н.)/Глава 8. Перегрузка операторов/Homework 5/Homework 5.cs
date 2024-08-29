/*Напишите программу; в которой есть класс с целочисленным полем и символьным
полем. Перегрузите операторы true и false так, чтобы «истинным» 
считался объект, у которого разность значения целочисленного поля
и кода символа из символьного поля не превышает величину 1О. Используйте
объект данного класса (в качестве условия в условном операторе) для
того, чтобы отобразить последовательность символов в консольном окне.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class MyClass
    {
        public int num;
        public char symb;

        public MyClass(int n, char s) 
        {
            num = n; 
            symb = s;
        }

        public static bool operator true(MyClass obj)
        {
            int count = obj.symb - obj.num;
            if (count < 10) return true;
            return false;
        }

        public static bool operator false(MyClass obj)
        {
            if (obj) return false;
            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(65, 'A');

            while (obj)
            {
                Console.Write((char)obj.symb);
                obj.symb = (char)(obj.symb + 1);
            }
            Console.WriteLine();
        }
    }
}
