/*Напишите программу, содержащую класс с индексатором. При индек-
сировании объекта в качестве значения соответствующего выражения
возвращается целое число и, соответственно, присваивается целое чис-
ло типа int. Присваиваемые значения записываются в массив с эле-
ментами типа byte. Используя обработку исключительных ситуаций
и инструкцию checked, опишите индексатор так, чтобы при попытке
присвоить проиндексированному объекту значение, выходящее за допу-
стимый диапазон для значений типа byte, соответствующий элемент
массива получал значение 255.*/

using System;

namespace Homework_I0
{
    class MyClass
    {
        byte[] nums;

        public MyClass(int size) { nums = new byte[size]; }

        public int this[int k]
        {
            get { return nums[k]; }
            set
            {
                try
                {
                    nums[k] = checked((byte)value);
                }
                catch 
                {
                    nums[k] = 255;
                }
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(5);

            myClass[0] = 240;
            Console.WriteLine(myClass[0]);

            myClass[0] = 260;
            Console.WriteLine(myClass[0]);

            myClass[0] = -10;
            Console.WriteLine(myClass[0]);
        }
    }
}
