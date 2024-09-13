/*Напишите программу, в которой есть базовый класс с открытым полем,
являющимся ссылкой на целочисленный массив. Конструктору
класса при создании передается ссылка на массив, в результате чего создается
копия этого массива и ссылка на него записывается в поле объекта.
Метод ToString() переопределен так, что возвращает текстовую
строку со значениями элементов массива. На основе базового класса создается
производный класс. В производном классе появляется еще одно
открытое поле, являющееся ссылкой на символьный массив. Конструктору
производного класса передаются две ссылки: на целочисленный
массив и на символьный массив. В результате должны создаваться копии
этих массивов, а ссылки на созданные массивы записываются в поля
объекта. Метод ToString() должен возвращать текстовую строку с содержимым
обоих массивов.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class MyClass{
        public int[] nums;

        public MyClass(int[] nums)
        {
            this.nums = nums; 
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < nums.Length; i++)
            {
                text += nums[i];
            }
            return text;
        }
    }

    class SecondClass : MyClass
    {
        public char[] symbs;

        public SecondClass(int[] nums, char[] symbs) : base (nums)
        {
            this.symbs = symbs;
            this.nums = nums;
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < nums.Length; i++)
            {
                text += nums[i];
            }
            text += " ";
            for (int i = 0; i < symbs.Length; i++)
            {
                text += symbs[i];
            }
            return text;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            MyClass a = new MyClass(nums);
            Console.WriteLine(a);

            char[] symbs = { 'a', 'b', 'c', 'd', };
            SecondClass b = new SecondClass(nums, symbs);
            Console.WriteLine(b);
        }
    }
}
