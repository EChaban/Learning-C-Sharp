/*Напишите программу, в которой есть класс с символьным полем
и следующими перегруженными операторами: оператором инкремента
++ и декремента -- , бинарным оператором "плюс" + и бинарным оператором
"минус" - . Правила перегрузки операторов такие. Применение
оператора инкремента к объекту приводит к тому, что поле значением получает
следующий (по отношению к текущему значению) символ в кодовой
таблице. Применение оператора декремента приводит к тому, что
поле получает значением предыдущий (по отношению к текущему значению)
символ в кодовой таблице. Значением выражения на основе оператора
инкремента/декремента является ссылка на объект-операнд. Бинарный
оператор "плюс" можно применять для вычисления суммы объекта
и целого числа, а также суммы целого числа и объекта. В обоих случаях
результатом возвращается новый объект, значение символьного поля
которого определяется прибавлением целого числа (один из операндов)
к коду символа из объекта-операнда. С помощью бинарного оператора
"минус" можно вычислять разность двух объектов. Результатом является
целое число - разность кодов символов из объектов-операндов.*/

using System;

namespace Homework_1
{
    class MyClass
    {
        public char symb;

        public MyClass(char s)
        {
            symb = s;
        }

        public static MyClass operator++(MyClass s)
        {
            s.symb += (char)1;
            return s;
        }

        public static MyClass operator--(MyClass s)
        {
            s.symb -= (char)1;
            return s;
        }

        public static MyClass operator+(MyClass s, int n)
        {
            MyClass newObj = new MyClass((char)(s.symb + n));
            return newObj;
        }

        public static MyClass operator+(int n, MyClass s)
        {
            MyClass newObj = new MyClass((char)(s.symb + n));
            return newObj;
        }

        public static int operator-(MyClass symb1, MyClass symb2)
        {
            int result = symb1.symb - symb2.symb;
            return result;
        }

        public override string ToString()
        {
            return "Символ: " + symb;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass('a');
            MyClass obj2 = new MyClass('b');

            Console.WriteLine(obj1++);
            Console.WriteLine(obj1--);
            Console.WriteLine(obj1 + 10);
            Console.WriteLine(20 + obj2);
            Console.WriteLine(obj2 - obj1);
        }
    }
}
