/*Напишите программу, в которой есть базовый класс с защищенным
целочисленным массивом, индексатором (с целочисленным индексом),
позволяющим считывать и присваивать значения элементам массива,
а также свойство, возвращающее результатом размер массива. На основе
базового класса создается производный класс, у которого появляется
защищенный символьный массив. Опишите в производном классе версию
индексатора с символьным индексом, который возвращает значение
элемента символьного массива и позволяет присвоить значение элементу
символьного массива. Для свойства из базового класса необходимо
выполнить замещение так, чтобы результатом возвращался целочисленный
массив из двух элементов: первый элемент определяет размер целочисленного
массива объекта, а второй элемент определяет размер символьного
массива объекта.*/

using System;

namespace Homework_I0
{
    class FirstClass
    {
        protected int[] nums;

        public FirstClass(int size) 
        { nums = new int[size]; }

        public int this[int i]
        {
            get { return nums[i]; }
            set { nums[i] = value; }
        }

        public int Length
        {
            get { return nums.Length; }
        }
    }

    class SecondClass : FirstClass
    {
        protected char[] chars;

        public SecondClass(int size) : base(size) 
        { chars = new char[size]; }

        public char this[char i]
        {
            get { return chars[i - 'a']; }
            set { chars[i - 'a'] = value; }
        }

        public new int[] Length
        {
            get
            {
                int[] Length = new int[2];
                Length[0] = nums.Length;
                Length[1] = chars.Length;
                return Length;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass first = new FirstClass(5);
            SecondClass second = new SecondClass(5);

            int n = 10;
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = n;
                n++;
            }

            for (int i = 0; i < first.Length; i++)
            {
                Console.Write(first[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            n = 20;
            char s = 'a';
            int[] size = second.Length;
            for (int i = 0; i < size[0]; i++, n++, s++)
            {
                second[i] = n;
                second[s] = s;
            }

            s = 'a';
            for (int i = 0; i < size[0]; i++, s++)
            {
                Console.WriteLine(second[i] + "\t" + second[s]);
            }
        }
    }
}
