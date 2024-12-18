﻿/*Напишите программу, в которой есть класс с событием. Событие об-
рабатывается методами, имеющими текстовый аргумент и не возвра-
щающими результат. У класса должно быть текстовое поле, в которое
при создании объекта класса записывается название объекта. В классе
должен быть описан метод для генерирования события, который вызы-
вается без аргументов. При генерировании события аргументом пере-
дается значение текстового поля объекта, генерирующего событие. Еще
один класс, описанный в программе, должен содержать метод с тексто-
вым аргументом, не возвращающий результат. При вызове метод ото-
бражает значение своего текстового аргумента. В главном методе про-
граммы необходимо создать два объекта первого класса и один объект
второго класса. Для событий объектов первого класса обработчиком ре-
гистрируется метод объекта второго класса (получается, что метод одно-
го и того же объекта зарегистрирован обработчиком для событий двух
объектов). Для каждого из объектов первого класса необходимо сгене-
рировать событие. При этом метод, зарегистрированный обработчиком,
должен выводить название объекта, сгенерировавшего событие.*/

using System;

namespace Homework_I0
{
    delegate void MyDelegate(string text);

    class MyClass1
    {
        private readonly string Text;

        public MyClass1(string text)
        {
            Text = text;
        }

        public event MyDelegate MyEvent;

        public void GenerationMyEvent() 
        {
            MyEvent?.Invoke(Text);
        }
    }

    class MyClass2
    {
        public void Method(string text) { Console.WriteLine(text); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass1 obj1 = new MyClass1("Текст 1");
            MyClass1 obj2 = new MyClass1("Текст 2");
            MyClass2 obj3 = new MyClass2();

            obj1.MyEvent += obj3.Method;
            obj2.MyEvent += obj3.Method;

            obj1.GenerationMyEvent();
            obj2.GenerationMyEvent();
        }
    }
}
