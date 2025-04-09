/*Напишите программу, содержащую структуру с символьным и цело-
численным полями, а также метод, который при вызове отображает зна-
чения этих полей. Создайте указатель на экземпляр структуры и с помо-
щью этого указателя присвойте значения полям экземпляра структуры
и вызовите метод из экземпляра.*/

using System;

namespace Homework_5
{

    unsafe internal class Program
    {
        struct MyStruct
        {
            public int n;
            public char sym;
            public void Show()
            {
                Console.WriteLine(n + ", " + sym);
            }
        }

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.Show();

            MyStruct* p = &myStruct;
            p->n = 55;
            p->sym = 'C';
            myStruct.Show();
        }
    }
}
