/*Напишите программу, в которой есть класс с целочисленным полем
и текстовым полем. Выполните перегрузку всех операторов сравнения.
Сравнение на предмет «больше» или «меньше» выполняется на основе
сравнения длины текстовых значений (имеются в виду текстовые поля
сравниваемых объектов). При сравнении на предмет «больше или равно» 
или «меньше или равно» сравниваются значения целочисленных
полей объектов. При сравнении на предмет «равно» или «не равно»
сравниваются и целочисленные, и текстовые поля объектов. Также предложите
способ переопределения методов Equals() и GetHashCode().*/

using System;

namespace Homework_4
{
    class MyClass
    {
        public int num;
        public string text;

        public MyClass(int n, string t)
        {
            num = n;
            text = t;
        }

        public override string ToString()
        {
            string result = "num = " + num + "\n" + "text = " + text;
            return result; 
        }

        public static bool operator >(MyClass obj1, MyClass obj2)
        {
            if (obj1.text.Length > obj2.text.Length) return true;
            else return false;
        }

        public static bool operator <(MyClass obj1, MyClass obj2)
        {
            if (obj1 > obj2) return false;
            else return true;
        }

        public static bool operator >=(MyClass obj1, MyClass obj2)
        {
            if (obj1.num > obj2.num) return true;
            else return false;
        }

        public static bool operator <=(MyClass obj1, MyClass obj2)
        {
            if (obj1 > obj2) return false;
            else return true;
        }

        public static bool operator ==(MyClass obj1, MyClass obj2)
        {
            if (obj1.text == obj2.text && obj1.num == obj2.num) return true;
            else return false;
        }

        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            if (obj1 == obj2) return false;
            else return true;
        }

        public override bool Equals(object obj)
        {
            MyClass myClass = (MyClass)obj;
            if (text == myClass.text && num == myClass.num) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            int strNum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                strNum += (int)text[i];
            }
            return num ^ strNum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(5, "Hello");
            MyClass obj2 = new MyClass(10, "World");
            Console.WriteLine(obj1 + "\n" + obj2);
            Console.WriteLine();

            Console.WriteLine("obj1 > obj2: " + (obj1 > obj2));
            Console.WriteLine();

            Console.WriteLine("obj1 < obj2: " + (obj1 < obj2));
            Console.WriteLine();

            Console.WriteLine("obj1 >= obj2: " + (obj1 >= obj2));
            Console.WriteLine();

            Console.WriteLine("obj1 <= obj2: " + (obj1 <= obj2));
            Console.WriteLine();

            Console.WriteLine("obj1 == obj2: " + (obj1 == obj2));
            Console.WriteLine();

            Console.WriteLine("obj1 != obj2: " + (obj1 != obj2));
            Console.WriteLine();

            Console.WriteLine("obj1.Equals(obj2): " + (obj1.Equals(obj2)));
            Console.WriteLine();

            Console.WriteLine("obj1.GetHashCode(): " + (obj1.GetHashCode()));
            Console.WriteLine("obj2.GetHashCode(): " + (obj2.GetHashCode()));
            Console.WriteLine();
        }
    }
}
