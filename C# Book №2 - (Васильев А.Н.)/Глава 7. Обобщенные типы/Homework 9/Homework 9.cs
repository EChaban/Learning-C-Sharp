/*Напишите программу, в которой есть обобщенный класс. У обобщен-
ного класса есть поле, являющееся ссылкой на массив из элементов
обобщенного типа. Опишите для класса операторный метод для опера-
тора +, позволяющий вычислять сумму двух объектов класса. Результа-
том является объект этого же класса. Массив в объекте-результате полу-
чается объединением массивов суммируемых объектов.*/

using System;

namespace Homework_9
{
    class MyClass<T>
    {
        T[] _values;

        public T[] Values
        {
            set { _values = value; }
            get { return _values; }
        }

        public T this[int i]
        {
            get => _values[i];
            set => _values[i] = value;
        }

        public override string ToString()
        {
            return string.Join(", ", _values);
        }

        public static MyClass<T> operator +(MyClass<T> obj1, MyClass<T> obj2)
        {
            // Объединение двух массивов
            T[] combined = new T[obj1.Values.Length + obj2.Values.Length];
            obj1.Values.CopyTo(combined, 0);
            obj2.Values.CopyTo(combined, obj1.Values.Length);

            return new MyClass<T> { Values = combined };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new MyClass<int> { Values = new int[] { 1, 2, 3 } };
            var obj2 = new MyClass<int> { Values = new int[] { 4, 5 } };

            var result = obj1 + obj2;

            Console.WriteLine("Result: " + result);
        }
    }
}
