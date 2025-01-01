/*Напишите программу, в которой объявлены две структуры. У первой
структуры есть целочисленное поле, а у второй структуры есть два цело-
численных поля. Предложите операторный метод, с помощью которого
сумма двух экземпляров первой структуры возвращала бы результатом
экземпляр второй структуры (поля экземпляра-результата — это поля
суммируемых экземпляров). Во второй структуре опишите метод, кото-
рый результатом возвращает массив из двух экземпляров первой струк-
туры. В этом случае экземпляр с двумя полями, из которого вызывается
метод, «разбивается» на два экземпляра, у каждого из которых по одно-
му полю.*/

using System;

namespace Homework_I0
{
    struct FirstStruct
    {
        private int num;

        public int Property
        {
            get { return num; }
            set { num = value; }
        }

        public static SecondStruct operator +(FirstStruct s1, FirstStruct s2)
        {
            return new SecondStruct
            {
                Property = new int[2] { s1.Property, s2.Property }
            };
        }
    }

    struct SecondStruct
    {
        private int num1;
        private int num2;

        public int[] Property
        {
            set { num1 = value[0]; num2 = value[1]; }
            get { return new int[2] { num1, num2 }; }
        }

        public FirstStruct[] GetArray()
        {
            return new FirstStruct[2]
            {
                new FirstStruct { Property = num1 },
                new FirstStruct { Property = num2 }
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем два экземпляра первой структуры
            FirstStruct first1 = new FirstStruct { Property = 10 };
            FirstStruct first2 = new FirstStruct { Property = 20 };

            // Используем оператор сложения
            SecondStruct second = first1 + first2;

            // Выводим результат сложения
            Console.WriteLine($"SecondStruct fields: {second.Property[0]}, {second.Property[1]}");

            // Преобразуем SecondStruct в массив FirstStruct
            FirstStruct[] array = second.GetArray();

            // Выводим элементы массива
            Console.WriteLine($"FirstStruct array elements: {array[0].Property}, {array[1].Property}");

            Console.ReadLine();
        }
    }
}
