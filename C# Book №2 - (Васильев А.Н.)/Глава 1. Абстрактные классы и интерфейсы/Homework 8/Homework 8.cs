/*Напишите программу, в которой класс создается на основе двух ин-
терфейсов. В каждом из интерфейсов объявлено текстовое свойство
с одним и тем же названием, доступное только для чтения. В классе вы-
полнить общую (неявную) реализацию свойства, а также явную спе-
циализацию свойства для каждого из интерфейсов. Проверьте значение
свойства для объекта класса, выполнив ссылку на объект через объект-
ную переменную и интерфейсные переменные.*/

using System;

namespace Homework_8
{
    interface IFirstText
    {
        string text { get; }
    }

    interface ISecondText
    { 
        string text { get; }
    }

    class MyClass : IFirstText, ISecondText
    {
        public string text { get; }

        string IFirstText.text
        {
            get { return "IFirstText " + text; }
        }
        string ISecondText.text
        {
            get { return "ISecondText " + text; }
        }

        public MyClass() { text = "Hello"; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            IFirstText first = obj;
            ISecondText second = obj;

            Console.WriteLine(obj.text);
            Console.WriteLine(first.text);
            Console.WriteLine(second.text);
        }
    }
}
