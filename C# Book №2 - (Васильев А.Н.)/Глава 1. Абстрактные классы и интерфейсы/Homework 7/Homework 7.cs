/*Напишите программу, в которой класс создается на основе двух интер-
фейсов. В первом интерфейсе есть целочисленное свойство, доступное
для чтения и записи. Во втором интерфейсе есть текстовое свойство, до-
ступное для чтения и записи. В каждом из интерфейсов объявлены оди-
наковые (с одинаковыми именами) методы, без аргументов, не возвра-
щающие результат. В классе описать соответствующий метод, который
в консольном окне отображает значения свойств.*/

using System;

namespace Homework_7
{
    interface INum
    {
        int Number { get; set; }
        void Print();
    }

    interface IText
    {
        string Text { get; set; }
        void Print();
    }

    class MyClass : INum , IText
    {
        public int Number { set; get; }
        public string Text { set; get; }

        public MyClass(int n, string t)
        {
            Number = n;
            Text = t;
        }

        void INum.Print()
        {
            Console.WriteLine("Number: " + this.Number);
        }

        void IText.Print()
        {
            Console.WriteLine("Text: " + this.Text);
        }

        public void Print()
        {
            Console.WriteLine($"Number: {this.Number}, Text: {this.Text}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5, "Hello");
            IText iText = obj;
            INum iNum = obj;

            obj.Print();
            iText.Print();
            iNum.Print();
        }
    }
}
