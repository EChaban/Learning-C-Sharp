/*Напишите программу с классом, у которого есть неотрицательное целочисленное поле. 
В классе нужно описать индексатор с целочисленным индексом и sеt-аксессором. 
Присваивание значения проиндексированному объекту обрабатывается следующим образом. 
В фактически присваиваемом значении берется только последняя цифра (остаток от деления
числа на 1О ) . Индекс определяет разряд в числовом значении
поля, в который записывается цифра. Нулевой разряд соответствует
единицам, единичный разряд соответствует десяткам, разряд два соответствует
сотням и так далее. Например, если объект проиндексирован
числом 1 и присваивается значение, заканчивающееся на 5 , то это означает,
что в числе, которое является значением поля, в разряд десятков
(разряд 1 ) нужно записать цифру 5.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class MyClass
    {
        private uint num;

        public MyClass(int num) { this.num = (uint)num; }

        public int this[int i]
        {
            set
            {
                int n = value % 10;
                string t = num.ToString();
                char[] chars = t.ToCharArray();

                chars[t.Length - 1 - i] = n.ToString()[0];
                t = new string(chars);
                num = uint.Parse(t);
            }
        }

        public int Property
        {
            get {return (int)num;}
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(12345);
            Console.WriteLine(obj.Property);

            obj[2] = 9;
            Console.WriteLine(obj.Property);
        }
    }
}
