using System;

namespace Homework_I0
{
    abstract class Base
    {
        public abstract string Text { get; set; }
        public abstract char this[int i] { get; set; }
        public abstract void Print();
    }

    interface IBase1
    {
        string Text { get; set; }
        char this[int i] { get; set; }
        void Print();
    }

    interface IBase2
    {
        string Text { get; set; }
        char this[int i] { get; set; }
        void Print();
    }

    class MyClass : Base, IBase1, IBase2
    {
        private string _text;

        public MyClass(string text)
        {
            _text = text;
        }

        public override string Text
        {
            get
            {
                Console.WriteLine("get from MyClass");
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        string IBase1.Text
        {
            get
            {
                Console.WriteLine("get from IBase1");
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        string IBase2.Text
        {
            get
            {
                Console.WriteLine("get from IBase2");
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        public override char this[int i]
        {
            get
            {
                Console.WriteLine("indexer from MyClass");
                return _text[i];
            }
            set
            {
                if (i < 0 || i >= _text.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                char[] tmp = _text.ToCharArray();
                tmp[i] = value;
                _text = new string(tmp); 
            }
        }

        char IBase1.this[int i]
        {
            get
            {
                Console.WriteLine("indexer from IBase1");
                return _text[i];
            }
            set
            {
                if (i < 0 || i >= _text.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                char[] tmp = _text.ToCharArray();
                tmp[i] = value;
                _text = new string(tmp);
            }
        }

        char IBase2.this[int i]
        {
            get
            {
                Console.WriteLine("indexer from IBase2");
                return _text[i];
            }
            set
            {
                if (i < 0 || i >= _text.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                char[] tmp = _text.ToCharArray();
                tmp[i] = value;
                _text = new string(tmp);
            }
        }

        public override void Print()
        {
            Console.WriteLine("Print from MyClass");
            Console.WriteLine(_text);
        }

        void IBase1.Print()
        {
            Console.WriteLine("Print from IBase1");
            Console.WriteLine(_text);
        }

        void IBase2.Print()
        {
            Console.WriteLine("Print from IBase2");
            Console.WriteLine(_text);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass("Hello world!");
            IBase1 iBase1 = obj;
            IBase2 iBase2 = obj;

            // Проверка работы свойства и метода
            obj.Print();
            iBase1.Print();
            iBase2.Print();

            // Тестируем индексатор
            Console.WriteLine("Original text: " + obj.Text);
            obj[6] = 'W'; // Изменяем символ
            Console.WriteLine("Updated text: " + obj.Text);
        }
    }
}
