/*Напишите программу, содержащую обобщенный класс с индексато-
ром обобщенного типа. Также в классе должно быть поле, являющееся
ссылкой на массив из элементов обобщенного типа. Считывание и при-
сваивание значений с использованием индексатора подразумевают счи-
тывание значений элементов массива и присваивание значений элемен-
там массива.*/

using System;

namespace Homework_4
{
    class MyClass<T>
    {
        private T[] _array;
        public T this[int i]
        {
            set { _array[i] = value; }
            get { return _array[i]; }
        }

        public MyClass(T[] array)
        {
            _array = array;
        }

        public MyClass()
        {
            _array = new T[10];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass[0] = 1;
            myClass[1] = 3;
            myClass[2] = 9;
            myClass[3] = 27;
            myClass[4] = 81;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(myClass[i] + " ");
            }
        }
    }
}
