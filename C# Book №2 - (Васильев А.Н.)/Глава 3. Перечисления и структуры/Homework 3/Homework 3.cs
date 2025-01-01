/*Напишите программу, содержащую структуру с полем, которое яв-
ляется символьным массивом. Предложите две версии конструктора:
с текстовым аргументом (символьный массив формируется на основе
текста) и с двумя аргументами (целое число и символ). В последнем
случае целочисленный аргумент определяет размер массива, а сим-
вольный аргумент определяет значение, которое присваивается всем
элементам массива. Опишите в структуре индексатор, который позво-
лял бы считывать значение символа из массива и присваивать значение
элементу массива. Предложите метод, который при вызове менял бы
порядок символов в массиве на противоположный. Переопредели-
те метод ToString() таким образом, чтобы он возвращал текстовую
строку, содержащую символы из массива и числовые коды этих сим-
волов.*/

using System;

namespace Homework_3
{
    internal class Program
    {
        struct MyStruct
        {
            char[] symbs;

            public MyStruct(string text)
            {
                symbs = text.ToCharArray();
            }

            public MyStruct(int n, char symb)
            {
                symbs = new char[n];
                for (int i = 0; i < n; i++)
                {
                    symbs[i] = symb;
                }
            }

            public char this[int i]
            {
                get { return symbs[i]; }
                set { symbs[i] = value; }
            }

            public void Reverse()
            {
                Array.Reverse(symbs);
            }

            public override string ToString()
            {
                string result = "| ";

                for (int i = 0; i < symbs.Length; i++)
                {
                    result += symbs[i] + " | ";
                }
                result += "\n| ";

                for (int i = 0; i < symbs.Length; i++)
                {
                    result += (int)symbs[i] + " | ";
                }
                
                return result;
            }
        }

        static void Main(string[] args)
        {
            MyStruct s1 = new MyStruct("text");
            MyStruct s2 = new MyStruct(5, 'b');

            Console.WriteLine(s1);
            Console.WriteLine();

            Console.WriteLine(s2);
            Console.WriteLine();

            s1.Reverse();
            Console.WriteLine(s1);
            Console.WriteLine();

            s2[0] = 'a';
            Console.WriteLine(s2);
            Console.WriteLine();

        }
    }
}