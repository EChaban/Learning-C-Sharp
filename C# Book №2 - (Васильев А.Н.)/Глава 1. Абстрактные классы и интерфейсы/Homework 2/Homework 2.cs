/*Напишите программу, содержащую базовый класс с защищенным
текстовым полем. У класса должен быть конструктор с текстовым аргументом, 
доступное для чтения абстрактное целочисленное свойство,
доступный для чтения абстрактный индексатор с целочисленным индексом, 
не возвращающий результат абстрактный метод с текстовым аргументом, 
не возвращающий результат абстрактный метод без аргументов. 
В производном классе: свойство результатом возвращает количество символов в текстовом поле, 
значением выражения с проиндексированным объектом является код символа в тексте, 
метод с текстовым аргументом присваивает новое значение полю, 
а метод без аргументов отображает значение поля в консольном окне.*/

using System;

namespace Homework_2
{
    abstract class BaseClass
    {
        protected string text;

        public BaseClass(string text)
        {
            this.text = text;
        }

        public abstract int Length { get; }

        public abstract int this[int index] { get; }

        public abstract void SetText(string newText);
        public abstract void PrintText();
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass(string text) : base(text) {}

        public override int Length
        {
            get { return text.Length; }
        }

        public override int this[int index]
        {
            get { return text[index]; }
        }

        public override void SetText(string newText)
        {
            text = newText;
        }

        public override void PrintText()
        {
            Console.WriteLine(text);
        }
    }

    internal class Program
    {
        static void Main()
        {
            DerivedClass obj = new DerivedClass("Hello");
            obj.PrintText();
            obj.SetText("Bye");
            obj.PrintText();
            for (int i = 0; i < obj.Length; i++)
            {
                Console.Write($"| {(char)obj[i]} ");
            }
            Console.Write("|\n");
        }
    }
}
