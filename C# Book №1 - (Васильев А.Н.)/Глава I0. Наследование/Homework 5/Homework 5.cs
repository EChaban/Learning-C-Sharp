/*Напишите программу, в которой использована цепочка наследования
из трех классов. В первом классе есть открытое символьное поле.
Во втором классе появляется открытое текстовое поле. В третьем классе
появляется открытое целочисленное поле. В каждом из классов должен
быть конструктор, позволяющий создавать объект на основе значений
полей, переданных аргументами конструктору, а также конструктор создания
копии.*/

using System;

namespace Homework_5
{
    class FirstClass
    {
        public char symb;

        public FirstClass(char symb)
        {
            this.symb = symb;
        }

        public FirstClass(FirstClass obj)
        {
            this.symb = obj.symb;
        }
    }

    class SecondClass : FirstClass
    {
        public string text;

        public SecondClass (char symb, string text) : base(symb)
        {
            this.text = text;
        }

        public SecondClass (SecondClass obj) : base (obj.symb)
        {
            this.text = obj.text;
        }
    }

    class ThirdClass : SecondClass
    {
        public int num;

        public ThirdClass (char symb, string text, int num) : base (symb, text)
        {
            this.num = num;
        }

        public ThirdClass (ThirdClass obj) : base (obj.symb, obj.text)
        {
            this.num = obj.num;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass a = new FirstClass('a');
            SecondClass b = new SecondClass('b', "Bbb");
            ThirdClass c = new ThirdClass('c', "Ccc", 3);

            Console.WriteLine($"{a.symb}");
            Console.WriteLine($"{b.symb} {b.text}");
            Console.WriteLine($"{c.symb} {c.text} {c.num}");

            Console.WriteLine();

            a = new FirstClass(c);
            Console.WriteLine($"{a.symb}");

            b = new SecondClass(c);
            Console.WriteLine($"{b.symb} {b.text}");

            ThirdClass d = new ThirdClass(c);
            Console.WriteLine($"{d.symb} {d.text} {d.num}");
        }
    }
}
