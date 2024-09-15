/*Напишите программу, в которой есть базовый класс с защищенным
текстовым полем, конструктором с текстовым аргументом и где переопределен
метод ToString(). На основе базового класса путем наследования
создается производный класс. У него появляется еще одно защищенное
текстовое поле. Также производный класс должен иметь версии
конструктора с одним и двумя текстовыми аргументами, а еще в нем
должен быть переопределен метод ToString(). В обоих классах метод
ToString() переопределяется так, что он возвращает строку с названием
класса и значение текстового поля или текстовых полей.*/

using System;

namespace Homework_1
{
    class MyBaseClass
    {
        protected string text;

        public MyBaseClass(string text)
        {
            this.text = text;
        }

        public override string ToString(){
            return $"MyBaseClass: {text}";
        }
    }

    class InheritClass : MyBaseClass
    {
        protected string secondText;

        public InheritClass(string text) : base (text) 
        {
            this.secondText = string.Empty;
        }

        public InheritClass(string text, string secondText) : base(text)
        {
            this.secondText = secondText;
        }

        public override string ToString()
        {
            return $"InheritClass: {text}, {secondText}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass a = new MyBaseClass("text 1");
            Console.WriteLine(a);
            InheritClass b = new InheritClass("text 2");
            Console.WriteLine(b);
            InheritClass c = new InheritClass("text 3", "text 4");
            Console.WriteLine(c);
        }
    }
}
