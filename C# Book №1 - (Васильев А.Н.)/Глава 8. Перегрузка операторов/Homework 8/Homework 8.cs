/*Напишите программу, в которой есть класс с полем, являющимся
ссылкой на целочисленный массив. Опишите в классе операторные
методы для выполнения приведений типов. Необходимо реализовать
следующие правила приведения типов. При преобразовании объекта
в текст возвращается текстовая строка со значениями элементов массива.
При преобразовании объекта в число возвращается сумма элементов
массива. При преобразовании числа в объект результатом является
новый объект, размер массива в котором определяется преобразуемым
числом. Массив в объекте должен быть заполнен нулями.*/

using System;
using System.Linq;

namespace Homework_8
{
    internal class Program
    {
        class MyClass
        {
            public int[] myArray;

            public MyClass (int num)
            {
                myArray = new int[num];
            }

            public static implicit operator string (MyClass obj)
            {
                string text = "";
                for (int i = 0; i < obj.myArray.Length; i++)
                    text += obj.myArray[i];
                return text;
            }

            public static implicit operator int(MyClass obj)
            {
                int sum = obj.myArray.Sum();
                return sum;
            }

            public static implicit operator MyClass(int num)
            {
                MyClass newObj = new MyClass(num);
                return newObj;
            }
        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            for (int i = 0; i < obj.myArray.Length; i++)
                Console.Write(obj.myArray[i] + " ");
            Console.WriteLine();

            Console.WriteLine((string)obj);

            Console.WriteLine((int)obj);

            Console.WriteLine((string)((MyClass)10));
        }
    }
}
