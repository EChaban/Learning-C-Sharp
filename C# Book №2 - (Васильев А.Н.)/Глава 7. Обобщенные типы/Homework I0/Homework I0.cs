/*Напишите программу, в которой есть обобщенный класс с двумя об-
общенными параметрами (первый и второй). У класса есть два поля,
являющихся ссылками на массивы из элементов обобщенного типа
(первого и второго). Массивы имеют одинаковые размеры. Опиши-
те индексатор, в котором индексом указывается значение второго об-
общенного типа, а результатом индексатора является значение перво-
го обобщенного типа. Предполагается, что индексом указывается одно
из значений из второго массива, а считывается или присваивается зна-
чение для соответствующего элемента из первого массива. Предложите
механизм добавления новых элементов в массивы и удаления уже суще-
ствующих элементов из массивов. Операции должны выполняться так,
чтобы количество элементов в обоих массивах было одинаковым.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_I0
{
    class MyClass<X, Y>
    {
        X[] xes;
        Y[] ys;

        public X[] Xes
        {
            get { return xes; }
            set { xes = value; }
        }

        public Y[] Ys
        {
            get { return ys; }
            set { ys = value; }
        }

        public MyClass(int size)
        {
            xes = new X[size];
            ys = new Y[size];
        }

        public X this[Y k]
        {
            get
            {
                int i = Array.IndexOf(ys, k);
                return xes[i];
            }
            set
            {
                int i = Array.IndexOf(ys, k);
                xes[i] = value;
            }
        }

        public void AddElement(X newX,Y newY)
        {
            X[] newXes = new X[xes.Length + 1];
            Y[] newYs = new Y[ys.Length + 1];

            Array.Copy(xes, newXes, xes.Length);
            newXes[newXes.Length - 1] = newX;
            xes = newXes;

            Array.Copy(ys, newYs, ys.Length);
            newYs[newYs.Length - 1] = newY;
            ys = newYs;
        }

        public void RemoveElement(X delX, Y delY)
        {
            int xIndex = Array.IndexOf(xes, delX);
            int yIndex = Array.IndexOf(ys, delY);

            List<X> newXes = xes.ToList();
            List<Y> newYs = ys.ToList();

            newXes.Remove(delX);
            newYs.Remove(delY);

            xes = newXes.ToArray();
            ys = newYs.ToArray();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, char> myClass = new MyClass<int, char>(1);

            int n = 1;
            char s = 'a';
            for (int i = 0; i < 9; i++, n++, s++)
            {
                myClass.AddElement(n, (char)(s));
            }
            myClass.RemoveElement(0, default(char));

            Console.WriteLine(String.Join(", ", myClass.Xes));
            Console.WriteLine(String.Join(", ", myClass.Ys));

            Console.WriteLine();

            Console.WriteLine(myClass['a']);
            Console.WriteLine(myClass['b']);
            Console.WriteLine(myClass['c']);
        }
    }
}
