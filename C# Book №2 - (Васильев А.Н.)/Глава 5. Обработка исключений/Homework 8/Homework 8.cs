/*Напишите программу, в которой описывается класс для ошибки поль-
зовательского типа. У класса должно быть поле, являющееся ссылкой
на символьный массив. В качестве аргумента конструктору класса пере-
дается целое число, определяющее размер массива. Массив заполняется
последовательностью букв (например, начиная с буквы 'A'). В главном
методе программы для реализации символьного массива создается объект
исключения пользовательского класса. Для отображения содержимого
массива искусственно генерируется исключение, а обработка исключения
сводится к отображению содержимого массива из объекта исключения.*/

using System;

namespace Homework_8
{
    class MyExeption: ApplicationException
    {
        char[] chars;

        public MyExeption(int size)
        {
            chars = new char[size];
            char tmp = 'A';
            for (int i = 0; i < chars.Length; i++, tmp++)
            {
                chars[i] = tmp;
            }
        }

        public override string ToString()
        {

            return new string(chars);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyExeption myExeption = new MyExeption(10);
                throw myExeption;
            }
            catch(MyExeption myExeption)
            {
                Console.WriteLine(myExeption);
            }
        }
    }
}
