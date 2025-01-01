/*Напишите программу, в которой есть структура с двумя целочислен-
ными полями. Опишите в структуре операторные методы для выпол-
нения операций сложения, вычитания и умножения двух экземпляров
структуры. Во всех случаях результатом должен быть новый экземпляр
структуры, значения полей которого вычисляются соответственно как
сумма, разность или произведение соответствующих полей экземпля-
ров-операндов. Предложите два операторных метода для унарных опе-
раторов, которые возвращали бы результатом наибольшее и наименьшее
из значений полей экземпляра структуры.*/

using System;
using System.Linq;

namespace Homework_6
{
    struct MyStruct
    {
        int field1;
        int field2;

        public MyStruct(int n1, int n2)
        {
            field1 = n1;
            field2 = n2;
        }

        public static MyStruct operator +(MyStruct s1, MyStruct s2)
        {
            MyStruct result = new MyStruct();
            result.field1 = s1.field1 + s2.field1;
            result.field2 = s1.field2 + s2.field2;
            return result;
        }

        public static MyStruct operator -(MyStruct s1, MyStruct s2)
        {
            MyStruct result = new MyStruct();
            result.field1 = s1.field1 - s2.field1;
            result.field2 = s1.field2 - s2.field2;
            return result;
        }

        public static MyStruct operator *(MyStruct s1, MyStruct s2)
        {
            MyStruct result = new MyStruct();
            result.field1 = s1.field1 * s2.field1;
            result.field2 = s1.field2 * s2.field2;
            return result;
        }

        public static int operator +(MyStruct s1)
        {
            return Math.Max(s1.field1, s1.field2);
        }

        public static int operator -(MyStruct s1)
        {
            return Math.Min(s1.field1, s1.field2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct s1 = new MyStruct(2,2);
            MyStruct s2 = new MyStruct(5,5);

            MyStruct sPlus = s2 + s1;
            MyStruct sMinus = s2 - s1;

            Console.WriteLine(+sPlus);
            Console.WriteLine(-sMinus);
        }
    }
}
