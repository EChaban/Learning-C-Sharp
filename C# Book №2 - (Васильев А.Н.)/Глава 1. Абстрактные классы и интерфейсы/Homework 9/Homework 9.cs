/*Напишите программу, в которой класс создается на основе абстракт-
ного базового класса и интерфейса. В абстрактном классе есть поле,
являющееся ссылкой на защищенный символьный массив. Конструк-
тору класса передается текстовый аргумент, на основе которого созда-
ется и заполняется символьный массив. В абстрактном классе опиши-
те метод, который по целочисленному аргументу возвращает значение
символа с соответствующим индексом в массиве. Также в абстрактном
классе должен быть объявлен абстрактный метод с двумя аргументами
(целое число и символ), не возвращающий результат. В интерфейсе дол-
жен быть объявлен метод с таким же именем, но с одним текстовым ар-
гументом. Также в интерфейсе должен быть объявлен индексатор (с дву-
мя аксессорами) с символьным результатом и целочисленным индексом.
На основе абстрактного класса и интерфейса нужно создать класс. Аб-
страктный метод из базового класса переопределить таким образом,
чтобы он присваивал значение элементу массива, метод из интерфейса
должен создавать новый массив, а индексатор должен предоставлять до-
ступ к элементам массива.*/

using System;

namespace Homework_9
{
    abstract class BaseClass
    {
        protected char[] symbs;

        public BaseClass(string text)
        {
            symbs = text.ToCharArray();
        }

        public char GetSymb(int index)
        {
            return symbs[index];
        }

        public abstract void Method(int num, char symb);

    }

    interface IBase
    {
        void Method(string text);

        char this[int index] {  get; set; }
    }

    class MyClass : BaseClass , IBase
    {
        public MyClass(string text) : base(text) { }

        public override void Method(int num, char symb)
        {
            symbs[num] = symb;
        }

        void IBase.Method(string text)
        {
            symbs = text.ToCharArray();
        }

        char IBase.this[int index] 
        {
            get { return symbs[index]; }
            set { symbs[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass("Hello");
            BaseClass baseClass = obj;
            IBase ibase = obj;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(obj.GetSymb(i));
            }
            Console.WriteLine();

            obj.Method(0, 'a');
            for (int i = 0; i < 5; i++)
            {
                Console.Write(obj.GetSymb(i));
            }
            Console.WriteLine();

            ibase.Method("Bye");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(obj.GetSymb(i));
            }
            Console.WriteLine();

        }
    }
}
