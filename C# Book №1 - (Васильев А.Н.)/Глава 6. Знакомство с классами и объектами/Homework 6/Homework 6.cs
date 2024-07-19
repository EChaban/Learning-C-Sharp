/*Напишите программу с классом, в котором есть два закрытых целочисленных
поля (назовем их max и min ). Значение поля max не может
быть меньше значения поля min. Значения полям присваиваются с помощью
открытого метода. Метод может вызываться с одним или двумя
целочисленными аргументами. При вызове метода значения полям присваиваются
так: сравниваются текущие значения полей и значения аргумента
или аргументов, переданных методу. Самое большое из значений
присваивается полю max, а самое маленькое из значений присваивается
полю min. Предусмотрите конструктор, который работает по тому же
принципу, что и метод для присваивания значений полям. В классе также
должен быть метод, отображающий в консольном окне значения полей
объекта.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class MinMax
    {
        int _min, _max;

        public MinMax(int num)
        {
            int[] ints = { _min, _max, num };
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < _min) _min = ints[i];
                if (ints[i] > _max) _max = ints[i];
            }
        }
        public MinMax(int min, int max)
        {
            if (min < max)
            {
                _min = min;
                _max = max;
            }
            else
            {
                _max = min;
                _min = max;
            }
        }

        public void Set(int num)
        {
           if (num > _max) _max = num;
           else if (num < _min) _min = num;
        }

        public void Set(int min, int max)
        {
            int[] ints = { _min, _max, min, max };
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < _min) _min = ints[i];
                if (ints[i] > _max) _max = ints[i];
            }
        }

        public void WriteMinMax()
        {
            Console.WriteLine(_min + " " + _max);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Помещаем в поля min и max, числа 5 и 10: ");
            MinMax minMax = new MinMax(5, 10);
            Console.WriteLine("Отображаем при помоще метода WriteMixMax: ");
            minMax.WriteMinMax();
            Console.WriteLine("Помещаем в поле объекта число 2");
            minMax.Set(2);
            Console.WriteLine("Отображаем при помоще метода WriteMixMax: ");
            minMax.WriteMinMax();
            Console.WriteLine("Помещаем в поле объекта числа -10 и 100");
            minMax.Set(-10, 100);
            Console.WriteLine("Отображаем при помоще метода WriteMixMax: ");
            minMax.WriteMinMax();
        }
    }
}
