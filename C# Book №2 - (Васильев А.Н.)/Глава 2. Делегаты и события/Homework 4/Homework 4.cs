﻿/*Напишите программу, в которой объявляется делегат для работы
с методами, имеющими целочисленный аргумент и целочисленный
результат. Опишите класс с индексатором (доступен только для счи-
тывания значения). Индексатор результатом должен возвращать ссылку
на экземпляр делегата. Экземпляр делегата ссылается на метод, у которого
целочисленный аргумент. Результатом метод возвращает целочисленное
значение, получающееся возведением аргумента метода в степень, опреде-
ляемую индексом объекта. Общий эффект такой: если некоторый объект
obj класса проиндексировать с неотрицательным индексом k и в круглых
скобках указать аргумент n (команда вида obj[k](n)), то результатом
такого выражения должно быть значение n в степени k.*/

using System;

namespace Homework_4
{
    delegate int PowerDelegate(int n);

    class PowerCalculator
    {
        public PowerDelegate this[int k]
        {
            get
            {
                return n => (int)Math.Pow(n, k);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PowerCalculator obj = new PowerCalculator();
            Console.WriteLine(obj[3](2));
        }
    }
}
