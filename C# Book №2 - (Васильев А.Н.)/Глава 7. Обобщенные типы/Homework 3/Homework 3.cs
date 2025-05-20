/*Напишите программу, содержащую обобщенный класс со свойством
обобщенного типа. Значением свойства возвращается значение закры-
того поля обобщенного типа. При присваивании значения свойству зна-
чение присваивается закрытому полю.*/

using System;

namespace Homework_3
{
    class MyClass<T>
    {
        private T _date;

        public T Date { 
            get { return _date; } 
            set { _date = value; } 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> myClass = new MyClass<string>();
            myClass.Date = "learning C#";
            Console.WriteLine(myClass.Date);
        }
    }
}
