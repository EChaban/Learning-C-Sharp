/*Напишите программу, в которой есть класс с целочисленным массивом
и с индексатором. При считывании значения выражения с проиндексированным
объектом результатом возвращается значение элемента
массива. При присваивании значения выражению с проиндексированным
объектом значение присваивается элементу массива. Необходимо
описать индексатор так, чтобы при индексировании объекта первый индекс
отличался от нуля. Числовые значения, определяющие диапазон
изменения индекса (и, соответственно, размер целочисленного массива)
при индексировании объекта, передаются аргументами конструктору
класса.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        class MyClass
        {
            private int[] ints;
            private int firstI;
            private int secondI;

            public MyClass(int firstI, int secondI)
            {
                this.firstI = firstI;
                this.secondI = secondI;
                ints = new int[secondI - firstI + 1];
            }

            public int this[int i]
            {
                get
                {
                    if (i < firstI) return ints[0];
                    if (i > secondI) return ints[ints.Length - 1];
                    else
                    {
                        return ints[i - firstI];
                    }
                }

                set
                {
                    if (i < firstI) ints[0] = value;
                    if (i > secondI) ints[ints.Length - 1] = value;
                    else
                    {
                        ints[i - firstI] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(2,5);
            obj[10] = 5;
            Console.WriteLine(obj[10]);

            for (int i = 2; i < 6; i++)
            {
                obj[i] = i;
                Console.WriteLine(obj[i]);
            }
        }
    }
}
