/*Напишите программу, содержащую обобщенный статический метод.
В качестве аргумента методу передается значение обобщенного типа.
Методом в консольное окно выводится одно из трех разных сообщений,
в зависимости от типа переданного аргумента. Отслеживаются такие
случаи: аргументом является значение типа int, аргументом является
значение типа char, и аргументом передается значение типа, отличного
от int и char.*/

using System;

namespace Homework_8
{
    internal class Program
    {
        public static void Show<T>(T value)
        {
            if (value is int) Console.WriteLine("аргументом является значение типа int");
            else if (value is char) Console.WriteLine("аргументом является значение типа char");
            else if(value == null) Console.WriteLine("аргументом является null");
            else Console.WriteLine("аргумент не является типом int или char");
        }
        static void Main(string[] args)
        {
            Show(5);
            Show('a');
            Show("String");
            Show<string>(null);
        }
    }
}
