/*Напишите программу с классом, у которого есть закрытое целочисленное поле. 
Значение полю присваивается с помощью открытого метода.
Методу аргументом может передаваться целое число, а также метод может вызываться без аргументов. 
Если метод вызывается без аргументов, то поле получает нулевое значение. 
Если метод вызывается с целочисленным аргументом, то это значение присваивается полю. 
Однако если переданное аргументом методу значение превышает 1ОО, то значением полю присваивается число 1ОО. 
Предусмотрите в классе конструктор, который работает по тому же принципу, что и метод для присваивания значения полю. 
Также в классе должен быть метод, позволяющий проверить значение поля.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Test
    {
        int _num;

        public Test()
        {
            _num = 0;
        }

        public Test(int num)
        {
            if (num < 100) _num = num;
            else _num = 100;
        }

        public void Set()
        {
            _num = 0;
        }

        public void Set(int num)
        {
            if (num < 100) _num = num;
            else _num = 100;
        }

        public void WriteNum()
        {
            Console.WriteLine(_num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.Write("Создан объект test1 без аргументов: ");
            test.WriteNum();
            Console.WriteLine();

            Test test2 = new Test(10);
            Console.Write("Создан объект test2 с аргументов \"10\": ");
            test2.WriteNum();
            Console.WriteLine();

            Console.Write("Помещаем в поле объекта test1 значение \"50\": ");
            test.Set(50);
            test.WriteNum();
            Console.WriteLine();

            Console.Write("Вызываем метод test2.Set без аргумента, поместив в поле \"0\": ");
            test2.Set();
            test2.WriteNum();
            Console.WriteLine();

            Console.Write("Помещаем в поле объекта test2 значение \"150\": ");
            test2.Set(150);
            test2.WriteNum();
            Console.WriteLine();
        }
    }
}
