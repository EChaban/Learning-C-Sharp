/*Напишите программу, содержащую класс с индексатором. Через ин-
дексатор можно получить доступ к элементам закрытого целочисленно-
го массива. Используя обработку исключительных ситуаций, опишите
статический метод, аргументом которому передается объект класса, а ре-
зультатом возвращается размер закрытого массива в этом объекте.*/

using System;

namespace Homework_7
{
    class MyClass
    {
        private int[] _ints;

        public MyClass(int[] ints)
        {
            _ints = ints;
        }

        public int this[int k]
        {
            get { return _ints[k]; }
            set { _ints[k] = value; }
        }
    }

    
    internal class Program
    {
        static int SizeArray(MyClass myClass)
        {
            int result = 0;
            int tmp;
            try
            {
                while (true)
                {
                    tmp = myClass[result];
                    result++;
                }
            }
            catch
            {
                return result;
            }
        }

        static void Main(string[] args)
        {
            int[] ints = { 1,2,3,4,5,6};
            MyClass myClass = new MyClass(ints);
            Console.WriteLine(myClass[2]);
            Console.WriteLine(SizeArray(myClass));
        }
    }
}
