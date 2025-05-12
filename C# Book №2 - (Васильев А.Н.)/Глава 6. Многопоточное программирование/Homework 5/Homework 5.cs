/*Напишите программу, содержащую класс с двумя полями: одно явля-
ется ссылкой на целочисленный массив, а второе поле является ссылкой
на символьный массив. Создайте объект класса, а также запустите на вы-
полнение два дочерних потока. Один дочерний поток должен заполнить
символьный массив объекта, а второй дочерний поток должен заполнить
целочисленный массив объекта. Способ заполнения предложите само-
стоятельно (например, случайные символы и числа).*/

using System;
using System.Threading;

namespace Homework_5
{
    class MyClass
    {
        public int[] ints;
        public char[] chars;

        public MyClass(int size) 
        { 
            ints = new int[size];
            chars = new char[size];
        }
    }

    internal class Program
    {
        static void FillNumbers(MyClass obj)
        {
            Random rnd = new Random();
            for (int i = 0; i < obj.ints.Length; i++)
            {
                obj.ints[i] = rnd.Next(101);
            }
        }

        static void FillChars(MyClass obj)
        {
            Random rnd = new Random();
            for (int i = 0; i < obj.chars.Length; i++)
            {
                obj.chars[i] = (char)(rnd.Next(127));
            }
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(10);

            Thread intsThread = new Thread(() => FillNumbers(myClass));
            Thread charsThread = new Thread(() => FillChars(myClass));

            intsThread.Start();
            charsThread.Start();

            Thread.Sleep(1000);

            foreach (int i in myClass.ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (int i in myClass.chars)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
