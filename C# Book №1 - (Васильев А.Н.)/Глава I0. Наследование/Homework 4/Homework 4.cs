/*Напишите программу, в которой на основе базового класса создается
производный класс, а на основе этого производного класса создается
еще один производный класс (цепочка наследования из трех классов).
В первом базовом классе есть открытое целочисленное поле, метод
с одним аргументом для присваивания значения полю и конструктор
с одним аргументом. 
Во втором классе появляется открытое символьное
поле, метод с двумя аргументами для присваивания значения полям
(перегрузка метода из базового класса) и конструктор с двумя аргументами.
В третьем классе появляется открытое текстовое поле, метод с тремя
аргументами для присваивания значений полям (перегрузка метода
из базового класса) и конструктор с тремя аргументами. Для каждого
класса определите метод ToString() так, чтобы он возвращал строку
с названием класса и значениями всех полей объекта.*/

using System;

namespace Homework_4
{
    class FirstBase
    {
        public int num;

        public void Setter(int num)
        {
            this.num = num;
        }

        public FirstBase(int num)
        {
        this.num = num; 
        }

        public override string ToString()
        {
            return $"FirstBase\n{num}";
        }
    }

    class SecondInherit : FirstBase
    {
        public char symb;

        public void Setter(int num, char symb)
        {
            this.num = num;
            this.symb = symb;
        }

        public SecondInherit(int num, char symb) : base (num)
        {
            this.num = num;
            this.symb = symb;
        }

        public override string ToString()
        {
            return $"SecondInherit\n{num}\n{symb}";
        }
    }

    class ThirdInherit : SecondInherit
    {
        public string text;

        public void Setter(int num, char symb, string text)
        {
            this.num = num;
            this.symb = symb;
            this.text = text;
        }

        public ThirdInherit(int num, char symb, string text) : base (num, symb)
        {
            this.num = num;
            this.symb = symb;
            this.text = text;
        }

        public override string ToString()
        {
            return $"ThirdInherit\n{num}\n{symb}\n{text}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstBase a = new FirstBase(123);
            SecondInherit b = new SecondInherit(456, 'b');
            ThirdInherit c = new ThirdInherit(789, 'c', "text");

            Console.WriteLine(a + "\n");
            Console.WriteLine(b + "\n");
            Console.WriteLine(c + "\n");

            c.Setter(54321, 'd', "New Text");

            Console.WriteLine();

            Console.WriteLine(c + "\n");
        }
    }
}

