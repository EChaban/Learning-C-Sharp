/*Напишите программу, в которой есть базовый класс с открытым текстовым
полем. На его основе создается производный класс с дополнительным
открытым символьным полем. Опишите в базовом классе виртуальный метод,
который при вызове создает и возвращает результатом объект производного
класса. Переопределите в производном классе этот метод так, чтобы
он создавал и возвращал копию объекта, из которого вызывается.*/

using System;

namespace Homework_7
{
    class FirstClass
    {
        public string text;
        public virtual SecondClass GetObject() 
        { 
            SecondClass obj = new SecondClass();
            obj.text = this.text;
            return obj;
        }
    }

    class SecondClass : FirstClass
    {
        public char symb;

        public override SecondClass GetObject()
        {
            SecondClass obj = new SecondClass();
            obj.symb = this.symb;
            obj.text = this.text;
            return obj;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondClass obj1 = new SecondClass();
            obj1.text = "Example";
            obj1.symb = 'A';

            SecondClass obj2 = obj1.GetObject();  // Создаём копию объекта

            Console.WriteLine($"obj1: {obj1.text}, {obj1.symb}");
            Console.WriteLine($"obj2: {obj2.text}, {obj2.symb}");
        }
    }
}
