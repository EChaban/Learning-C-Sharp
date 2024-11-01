/*Напишите программу, содержащую абстрактный класс с двумя защи-
щенными целочисленными полями и конструктор с двумя целочислен-
ными аргументами. В классе должен быть объявлен абстрактный ин-
дексатор с целочисленным индексом. Опишите интерфейс, в котором
есть метод с целочисленным аргументом и целочисленным результатом.
Опишите класс, который наследует абстрактный базовый класс и реали-
зует интерфейс. В этом классе опишите индексатор так, чтобы при чет-
ном индексе выполнялось обращение к первому полю, а при нечетном
индексе обращение выполнялось ко второму полю. Метод следует опи-
сать таким образом, чтобы он результатом возвращал сумму значений
полей, умноженную на аргумент метода.*/

using System;

namespace Homework_4
{
    abstract class BaseClass
    {
        protected int firstValue;
        protected int secondValue;

        public BaseClass(int first, int second)
        {
            this.firstValue = first;
            this.secondValue = second;
        }

        public abstract int this[int index] { get; set; }
    }

    interface ICalculate
    {
        int Calculate(int num);
    }

    class MyClass : BaseClass, ICalculate
    {
        public MyClass(int first, int second) : base(first, second) { }

        public override int this[int num]
        {
            get
            {
                if (num % 2 == 0) return firstValue;
                else return secondValue;
            }
            set
            {
                if (num % 2 == 0) firstValue = value;
                else secondValue = value;
            }
        }

        public int Calculate(int multiplier)
        {
            return (firstValue + secondValue) * multiplier;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5, 6);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj.Calculate(2));
        }
    }
}
