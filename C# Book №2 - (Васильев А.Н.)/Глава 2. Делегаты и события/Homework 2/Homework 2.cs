/*Напишите программу, в которой объявляется делегат для методов
с символьным аргументом, не возвращающих результат. Опишите класс,
в котором должно быть символьное поле и метод, позволяющий присво-
ить значение символьному полю объекта. У метода один символьный
аргумент, и метод не возвращает результат. Создайте массив объектов
данного класса. Создайте экземпляр делегата. В список вызовов этого
делегата необходимо добавить ссылки на метод (присваивающий значе-
ние символьному полю) каждого объекта из массива. Проверьте резуль-
тат вызова такого экземпляра делегата.*/

using System;

delegate void TestDelegate(char symb);

namespace Homework_2
{
    class MyClass
    {
        char _symb;
        public void SetText(char symb)
        {
            _symb = symb;
        }

        public char GetText()
        {
            return _symb;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            MyClass obj2 = new MyClass();
            MyClass obj3 = new MyClass();
            MyClass[] myClasses = { obj1, obj2, obj3 };
            TestDelegate myDelegate;
            for (int i = 0; i < myClasses.Length; i++)
            {
                myDelegate = myClasses[i].SetText;
                myDelegate((char)('a' + i));
            }

            foreach (MyClass obj in myClasses)
            {
                Console.WriteLine(obj.GetText());
            }
        }
    }
}
