/*Напишите программу, в которой есть базовый класс с открытым целочисленным
полем. В классе описан виртуальный индексатор, позволяющий
считывать цифры в десятичном представлении числа (значение
поля). На основе базового класса создается производный класс, в котором
появляется еще одно открытое целочисленное поле. В производном
классе описывается версия индексатора с двумя индексами: первый индекс
определяет поле, значение которого используется, а второй индекс
определяет разряд, для которого считывается цифра. Индексатор с одним
индексом переопределяется так, что вычисления (считывание цифры
в десятичном представлении числа) производятся на основе значения,
равного сумме значений полей индексируемого объекта.*/

using System;

namespace Homework_8
{
    class FirstClass
    {
        public int num1;

        public virtual int this[int i]
        {
            get
            {
                string tmp = num1.ToString();
                char[] chars = tmp.ToCharArray();
                int[] newArray = Array.ConvertAll(chars, item => item - '0');
                return newArray[i];
            }
        }
    }

    class SecondClass : FirstClass
    {
        public int num2;

        public int this[int j, int i]
        {
            get
            {
                int numTmp;
                if (j == 1) numTmp = num1;
                else numTmp = num2;

                string tmp = numTmp.ToString();
                char[] chars = tmp.ToCharArray();
                int[] newArray = Array.ConvertAll(chars, item => item - '0');
                return newArray[i];
            }
        }

        public override int this[int i]
        {
            get
            {
                int numTmp = num1 + num2;

                string tmp = numTmp.ToString();
                char[] chars = tmp.ToCharArray();
                int[] newArray = Array.ConvertAll(chars, item => item - '0');
                return newArray[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass a = new FirstClass();
            a.num1 = 56789;
            Console.WriteLine(a[0] + " " + a[1]);

            SecondClass b = new SecondClass();
            b.num1 = 1234;
            b.num2 = 5678;
            Console.WriteLine("1234 + 5678 = {0}", b.num1 + b.num2);
            Console.WriteLine(b[0] + " " + b[1]);
            Console.WriteLine(b[1, 0]);
            Console.WriteLine(b[2, 3]);
        }
    }
}
