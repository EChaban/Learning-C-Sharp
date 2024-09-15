/*Напишите программу, в которой есть базовый класс с защищенным
текстовым полем, конструктор с текстовым аргументом и метод, при вызове
которого в консольном окне отображается название класса и значение
поля. На основе базового класса создаются два производных класса
(оба на основе одного и того же базового). В одном из классов появляется
защищенное целочисленное поле, там есть конструктор с двумя
аргументами и переопределен метод для отображения значений полей
объекта и названия класса. Во втором производном классе появляется
защищенное символьное поле, конструктор с двумя аргументами и переопределен
метод, отображающий в консоли название класса и значения
полей. В главном методе создайте объекты каждого из классов. Проверьте
работу метода, отображающего значения полей объектов, для каждого
из объектов. Вызовите этот же метод через объектную переменную базового
класса, которая ссылается на объект производного класса.*/

using System;

namespace Homework_6
{
    class FirstClass
    {
        protected string text;

        public FirstClass(string text)
        {
            this.text = text;
        }

        public virtual void Getter()
        {
            Console.WriteLine($"FirstClass {this.text}");
        }
    }

    class SecondClass : FirstClass
    {
        protected int num;

        public SecondClass(string text, int num) : base(text)
        {
            this.num = num;
        }

        public override void Getter()
        {
            Console.WriteLine($"SecondClass {this.text} {this.num}");
        }
    }

    class ThirdClass : FirstClass
    {
        protected char symb;

        public ThirdClass(string text, char symb) : base(text)
        {
            this.symb = symb;
        }

        public override void Getter()
        {
            Console.WriteLine($"ThirdClass {this.text} {this.symb}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass a = new FirstClass("AaAa");
            SecondClass b = new SecondClass("BbBb", 222);
            ThirdClass c = new ThirdClass("CcCc", 'c');

            a.Getter();
            b.Getter();
            c.Getter();

            Console.WriteLine();

            a = b;
            a.Getter();
            a = c;
            a.Getter();
        }
    }
}
