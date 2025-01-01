/*Напишите программу, в которой объявляется структура с целочис-
ленным, текстовым и символьным полями. Предложите такие версии
конструктора: с тремя аргументами (целое число, текст, символ), с дву-
мя аргументами (целое число и текст) и с одним аргументом (текст).
В структуре должен быть метод, при вызове которого отображаются зна-
чения полей экземпляра структуры.*/

using System;

namespace Homework_2
{
    struct MyStruct
    {
        int _num;
        string _text;
        char _symb;

        public MyStruct(int num, string text, char symb)
        {
            _num = num;
            _text = text;
            _symb = symb;
        }

        public MyStruct(int num, string text)
        {
            _num = num;
            _text = text;
            _symb = '*';
        }

        public MyStruct(string text)
        {
            _num = 0;
            _text = text;
            _symb = '*';
        }

        public void Display()
        {
            Console.WriteLine($"{_num}, {_text}, {_symb}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров структуры с разными конструкторами
            MyStruct struct1 = new MyStruct(42, "Hello, World!", 'A');
            MyStruct struct2 = new MyStruct(99, "C# Programming");
            MyStruct struct3 = new MyStruct("Default Values");

            // Вызов метода Display для каждого экземпляра
            struct1.Display();
            struct2.Display();
            struct3.Display();
        }
    }
}
