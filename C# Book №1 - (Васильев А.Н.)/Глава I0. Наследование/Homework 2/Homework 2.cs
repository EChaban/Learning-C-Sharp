/*Напишите программу, в которой есть базовый класс с защищенным
текстовым полем. В базовом классе должен быть метод для присваивания
значения полю: без аргументов и с одним текстовым аргументом.
Объект базового класса создается передачей одного текстового аргумента
конструктору. Доступное только для чтения свойство результатом
возвращает длину текстовой строки. Доступный только для чтения индексатор
возвращает значением символ из текстовой строки. На основе
базового класса создается производный класс. В производном классе появляется
дополнительное открытое целочисленное поле. В классе должны
быть такие версии метода для присваивания значений полям (используется
переопределение и перегрузка метода из базового класса) :
без аргументов, с текстовым аргументом, с целочисленным аргументом,
с текстовым и целочисленным аргументом. У конструктора производного
класса два аргумента (целочисленный и текстовый).*/

using System;

namespace Homework_2
{
    class BaseClass
    {
        protected string text;

        public BaseClass(string text)
        {
            this.text = text;
        }

        public virtual void Setter()
        {
            text = "text";
        }
        public virtual void Setter(string text)
        {
            this.text = text;
        }

        public int GetLength
        {
            get
            {
                return text.Length;
            }
        }

        public char this[int i]
        {
            get
            {
                return text[i];
            }
        }

        public string GetText()
        {
            string text = "";

            for (int i = 0; i < this.GetLength; i++)
            {
                text += this[i];
            }
            return text;
        }
    }

    class InheritClass : BaseClass
    {
        public int num;

        public InheritClass(int num, string text) : base(text)
        {
            this.num = num;
            this.text = text;
        }
        public override void Setter()
        {
            text = "text";
            num = 0;
        }

        public void Setter(int num)
        {
            text = "text";
            this.num = num;
        }

        public override void Setter(string text)
        {
            this.text = text;
            num = 0;
        }

        public void Setter(string text, int num)
        {
            this.text = text;
            this.num = num;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass("abc");
            Console.WriteLine(b.GetText());

            b.Setter();
            Console.WriteLine(b.GetText());

            b.Setter("new text");
            Console.WriteLine(b.GetText());

            InheritClass c = new InheritClass(10, "InheritClass text");
            Console.WriteLine(c.GetText());

            c.Setter("Inherit Text", 20);
            b = c;
            Console.WriteLine(b.GetText());
            Console.WriteLine(c.GetText() + " " + c.num);
        }
    }
}
