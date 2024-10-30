using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    abstract class Base
    {
        protected int[] array;

        public Base(int length)
        {
            this.array = new int[length];
        }

        public int Length { 
            get { return array.Length; } 
        }
        public abstract void Print();
        public abstract int this[int index]
        {
            get;
            set;
        }

    }

    class MyClass : Base
    {
        public MyClass(int length) : base(length) { }

        public override void Print()
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }

        public override int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = i;
            }

            obj.Print();

            Console.WriteLine();
            obj[0] = 11;
            Console.WriteLine(obj[0]);
        }
    }
}
