/* Напишите программу, в которой будет описан интерфейс с методом без
аргументов, который возвращает результатом целое число. На основе ин-
терфейса создайте два класса. У каждого класса должно быть целочислен-
ное поле. В первом классе метод результатом возвращает сумму четных
чисел, во втором классе метод возвращает результатом сумму нечетных чи-
сел. Количество слагаемых в сумме определяется полем объекта, из которо-
го вызывается метод. Проверьте работу метода, получив доступ к объекту
класса через объектную переменную и через интерфейсную переменную.*/

using System;

namespace Homework_3
{
    interface IBase
    {
        int CalculateSum();
    }

    class EvenSumCalculator : IBase
    {
        int count;

        public EvenSumCalculator(int num)
        {
            count = num;
        }

        public int CalculateSum()
        {
            int count = 0;
            for (int i = 2; i <= this.count; i += 2)
            {
                count += i;
            }
            return count;
        }
    }

    class OddSumCalculator : IBase
    {
        int count;

        public OddSumCalculator(int num)
        {
            count = num;
        }

        public int CalculateSum()
        {
            int count = 0;
            for (int i = 1; i <= this.count; i += 2)
            {
                count += i;
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EvenSumCalculator first = new EvenSumCalculator(10);
            OddSumCalculator second = new OddSumCalculator(10);
            IBase iBase1 = first;
            IBase iBase2 = second;

            Console.WriteLine($"FirstClass {first.CalculateSum()}");
            Console.WriteLine($"SecondClass {second.CalculateSum()}");
            Console.WriteLine($"IBase first {iBase1.CalculateSum()}");
            Console.WriteLine($"IBase second {iBase2.CalculateSum()}");
        }
    }
}
