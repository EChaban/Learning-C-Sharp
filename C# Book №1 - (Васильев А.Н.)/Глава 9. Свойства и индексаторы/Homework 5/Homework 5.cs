/*Напишите программу, в которой есть класс со статическим свойством.
При считывании значения свойства возвращается нечетное число, каждый
раз новое: при первом считывании свойства получаем значение 1,
затем 3, затем 5 и так далее. При присваивании значения свойству определяется
порядковый номер числа в последовательности нечетных чисел,
начиная с которого будут возвращаться числа. Например, если
присвоить свойству значение 5, то при считывании значения свойства
получаем число 9 (пятое по порядку нечетное число), затем число 11 ,
затем 13 и так далее.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class MyClass
    {
        static public int num = 1;

        static public int MyProperty
        { 
            get
            {
                int n = num;
                num += 2;
                return n;
            }

            set
            {
                num = 1;
                for (int i = 1; i < value; i++)
                {
                    num += 2;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.MyProperty = 3;
            Console.WriteLine(MyClass.MyProperty);

            MyClass.MyProperty = 6;
            Console.WriteLine(MyClass.MyProperty);
        }
    }
}
