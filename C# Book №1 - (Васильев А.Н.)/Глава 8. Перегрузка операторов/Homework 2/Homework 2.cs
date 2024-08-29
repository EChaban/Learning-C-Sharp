/*Напишите программу, в которой есть класс с полем, являющимся ссылкой на одномерный целочисленный массив. 
У класса есть конструктор с одним целочисленным аргументом, определяющим размер массива. 
При создании объекта все элементы массива получают нулевые значения. 
В классе перегружаются следующие операторы. 
Унарный оператор ~ перегружен таким образом, что результатом возвращается текстовая
строка со значениями элементов массива (на который ссылается поле объекта, к которому применяется оператор). 
Унарный оператор инкремента ++ перегружен так, что его применение к объекту приводит
к добавлению в массив нового элемента с нулевым значением. 
Результатом возвращается ссьmка на объект-операнд. 
При применении к объекту оператора декремента -- из массива удаляется один элемент 
(например, последний), а результатом возвращается ссылка на объект-операнд. 
Бинарный оператор сложения + должен быть определен так, чтобы можно
было вычислять сумму двух объектов, объекта и числа, а также числа
и объекта. Во всех случаях результатом возвращается новый объект.
Если в операции участвуют два объекта-операнда, то в объекте-результате
массив формируется объединением массивов складываемых объектов.
Если вычисляется сумма объекта и числа, то в объекте-результате
массив получается добавлением нового элемента к массиву из объекта-операнда. 
Значение добавляемого элемента определяется значением числа-операнда. 
Если к числу прибавляется объект, то новый элемент добавляется в начало массива. 
Если к объекту прибавляется число, то новый элемент добавляется в конец массива.*/

using System;

namespace Homework_2
{
    class MyClass
    {
        public int[] ints;

        public MyClass(int n)
        {
            ints = new int[n];
        }

        public static string operator ~(MyClass obj)
        {
            string text = "";
            for (int i = 0; i < obj.ints.Length; i++)
            {
                text += obj.ints[i] + " ";
            }
            return text;
        }

        public static MyClass operator++(MyClass obj)
        {
            int[] newArray = new int[obj.ints.Length + 1];
            Array.Copy(obj.ints, newArray, obj.ints.Length);
            obj.ints = newArray;
            return obj;
        }

        public static MyClass operator --(MyClass obj)
        {
            int[] newArray = new int[obj.ints.Length - 1];
            Array.Copy(obj.ints, newArray, obj.ints.Length - 1);
            obj.ints = newArray;
            return obj;
        }

        public static MyClass operator +(MyClass obj1, MyClass obj2)
        {
            MyClass objLonger;
            MyClass objShorter;
            if (obj1.ints.Length > obj2.ints.Length)
            {
                objLonger = new MyClass(obj1.ints.Length);
                Array.Copy(obj1.ints, objLonger.ints, obj1.ints.Length);

                objShorter = new MyClass(obj2.ints.Length);
                Array.Copy(obj2.ints, objShorter.ints, obj2.ints.Length);
            }
            else
            {
                objShorter = new MyClass(obj1.ints.Length);
                Array.Copy(obj1.ints, objShorter.ints, obj1.ints.Length);

                objLonger = new MyClass(obj2.ints.Length);
                Array.Copy(obj2.ints, objLonger.ints, obj2.ints.Length);
            }

            for (int i = 0; i < objShorter.ints.Length; i++)
            {
                objLonger.ints[i] = objLonger.ints[i] + objShorter.ints[i];
            }
            return objLonger;
        }

        public static MyClass operator +(int num, MyClass obj)
        {
            MyClass newObj = new MyClass(obj.ints.Length + 1);
            Array.Copy(obj.ints, 0, newObj.ints, 1, obj.ints.Length);
            newObj.ints[0] = num;
            return newObj;
        }

        public static MyClass operator +(MyClass obj, int num)
        {
            MyClass newObj = new MyClass(obj.ints.Length + 1);
            Array.Copy(obj.ints, 0, newObj.ints, 0, obj.ints.Length);
            newObj.ints[newObj.ints.Length - 1] = num;
            return newObj;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(5);
            MyClass obj2 = new MyClass(10);
            Console.WriteLine(~obj1 + "\n" + ~obj2);
            Console.WriteLine();

            for (int i = 0; i < obj1.ints.Length; i++)
            {
                obj1.ints[i] = i;
            }
            for (int i = 0; i < obj2.ints.Length; i++)
            {
                obj2.ints[i] = i;
            }
            Console.WriteLine(~obj1 + "\n" + ~obj2);
            Console.WriteLine();

            obj1++;
            --obj2;
            Console.WriteLine(~obj1 + "\n" + ~obj2);
            Console.WriteLine();

            Console.WriteLine(~(obj1 + obj2));
            Console.WriteLine();

            Console.WriteLine(~(obj1 + 100));
            Console.WriteLine();

            Console.WriteLine(~(100 + obj1));
            Console.WriteLine();
        }
    }
}
