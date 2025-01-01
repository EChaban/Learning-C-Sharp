/*Напишите программу, содержащую структуру с тремя закрытыми це-
лочисленными полями. Предложите версии конструктора с одним, дву-
мя и тремя целочисленными аргументами. В структуре должно быть два
целочисленных свойства. Одно свойство результатом возвращает наи-
меньшее из значений полей экземпляра структуры. Другое свойство воз-
вращает наибольшее из значений полей экземпляра структуры. Предло-
жите вариант обработки ситуации, когда первому или второму свойству
присваивается значение.*/

using System;
using System.Linq;

namespace Homework_5
{
    struct MyStruct
    {
        int field1;
        int field2;
        int field3;

        public MyStruct(int num1)
        {
            field1 = num1;
            field2 = 0;
            field3 = 0;
        }

        public MyStruct(int num1, int num2)
        {
            field1 = num1;
            field2 = num2;
            field3 = 0;
        }

        public MyStruct(int num1, int num2, int num3)
        {
            field1 = num1;
            field2 = num2;
            field3 = num3;
        }

        public int MinValue
        {
            get
            {
                int[] nums = { field1 , field2 , field3 };
                return nums.Min();
            }

            set
            {
                int[] nums = { field1, field2, field3 };
                int min = nums.Min();
                if (min < field1) field1 = value;
                else if (min < field2) field2 = value;
                else if (min < field3) field3 = value;
            }
        }

        public int MaxValue
        {
            get
            {
                int[] nums = { field1, field2, field3 };
                return nums.Max();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct s1 = new MyStruct(1);
            MyStruct s2 = new MyStruct(1,2);
            MyStruct s3 = new MyStruct(1,2,3);

            Console.WriteLine(s1.MinValue);
            Console.WriteLine(s1.MaxValue);
            Console.WriteLine();

            Console.WriteLine(s2.MinValue);
            Console.WriteLine(s2.MaxValue);
            Console.WriteLine();

            Console.WriteLine(s3.MinValue);
            Console.WriteLine(s3.MaxValue);
            Console.WriteLine();

            s3.MinValue = 5;

            Console.WriteLine(s3.MinValue);
            Console.WriteLine(s3.MaxValue);
            Console.WriteLine();
        }
    }
}