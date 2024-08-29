/*Напишите программу, в которой есть класс с текстовым полем. 
Опишите в классе операторные методы для выполнения приведения типов.
Необходимо определить следующие способы преобразований. 
При преобразовании объекта в целое число результатом возвращается количество
символов в значении текстового поля. При преобразовании объекта
в символ результатом является первый символ в тексте. При преобразовании
числа в объект создается (и возвращается результатом соответствующего
операторного метода) объект, текстовое поле которого содержит
текстовую строку из символов 'А'. Количество символов в тексте
определяется преобразуемым числом.*/

using System;

namespace Homework_7
{
    internal class Program
    {
        class MyClass
        {
            public string text;

            public MyClass(string t)
            {
                text = t;
            }

            public static implicit operator int(MyClass obj)
            {
                int num = obj.text.Length;
                return num;
            }

            public static implicit operator char(MyClass obj)
            {
                char symb = obj.text[0];
                return symb;
            }

            public static implicit operator MyClass(int num)
            {
                MyClass a = new MyClass("");
                for (int i = 0; i < num; i++)
                    a.text += "A";
                return a;
            }
        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass("Text");
            Console.WriteLine(obj.text);

            int num = 0 + obj;
            Console.WriteLine(num);

            char symb = obj;
            Console.WriteLine(symb);

            Console.WriteLine((char)obj);

            obj = num;
            Console.WriteLine(obj.text);
        }
    }
}
