/*Напишите программу, в которой описаны два класса пользователь-
ских исключений (один создается наследованием класса Exception,
а другой создается наследованием класса ApplicationException).
Опишите класс с закрытым символьным массивом и индексатором, ко-
торый позволяет присваивать значения элементам массива и считывать
значения элементов массива. Определите индексатор таким образом,
чтобы при слишком большом индексе (выходящем за верхнюю границу)
генерировалось исключение первого пользовательского класса исклю-
чений, а при отрицательном индексе генерировалось исключение вто-
рого пользовательского класса. В главном методе предложите механизм
проверки функциональности индексатора для индексируемых объектов.*/

using System;

namespace Homework_9
{
    class IndexTooLargeException: Exception
    {
        public IndexTooLargeException(string message):base(message) { }
    }

    class NegativeIndexException : ApplicationException
    {
        public NegativeIndexException(string message) : base(message) { }
    }

    class MyClass
    {
        private char[] symbs;

        public MyClass(string text) 
        {
            symbs = text.ToCharArray();
        }
        public char this[int k]
        {
            get 
            {
                if (k >= symbs.Length) throw new IndexTooLargeException("Выход за верхнюю границу массива!");
                if (k < 0) throw new NegativeIndexException("Выход за нижнюю границу массива!");
                return symbs[k]; 
            }
            set 
            {
                if (k >= symbs.Length) throw new IndexTooLargeException("Выход за верхнюю границу массива!");
                if (k < 0) throw new NegativeIndexException("Выход за нижнюю границу массива!");
                symbs[k] = value; 
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("12345");

            try
            {
                // Корректная работа
                Console.WriteLine(myClass[1]);
                myClass[1] = '9';

                // Ошибка: индекс слишком большой
                Console.WriteLine(myClass[10]);
            }
            catch (IndexTooLargeException e)
            { 
                Console.WriteLine(e.Message);
            }
            catch (NegativeIndexException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                myClass[-1] = '9'; 
            }
            catch (IndexTooLargeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NegativeIndexException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
