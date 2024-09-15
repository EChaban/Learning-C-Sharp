/*Напишите программу, в которой есть базовый класс с защищенным
текстовым полем. В классе имеется виртуальное текстовое свойство,
возвращающее значением текст из текстового поля. При присваивании
значения свойству значение присваивается текстовому полю. В классе
переопределен метод ToString() : он возвращает текстовую строку
с названием класса и значением текстового поля. На основе базового
класса создается производный класс, у которого появляется еще одно
текстовое поле. Свойство переопределяется так, что значением возвращается
текст, получающийся объединением (через пробел) значений
текстовых полей объекта. При присваивании значения свойству присваиваемая
текстовая строка разбивается на две, которые присваиваются
полям объекта. Разделителем для разбивки строки на две подстроки
является пробел (первый с начала строки). Если пробела нет, то первая
подстрока совпадает с исходной строкой, а вторая подстрока пустая. Метод
ToString() для производного класса нужно переопределить таким
образом, чтобы он возвращал название класса и значения полей объекта.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    class FirstClass
    {
        protected string text;

        public virtual string MyProperty
        {
            get { return text; }
            set { text = value; }
        }

        public override string ToString() 
        {
            return $"FirstClass {text}";
        }
    }

    class SecondClass : FirstClass
    {
        protected string text2;

        public override string MyProperty
        {
            get { return text + " " + text2; }
            set
            {
                int i = value.IndexOf(' ');
                if (i > 0 && i < value.Length - 1)
                {
                    text = value.Substring(0, i);
                    text2 = value.Substring(i + 1);
                }
                else if (i == 0)
                {
                    text = value.Trim();
                    text2 = "";
                }
                else 
                {
                    text = value;
                    text2 = "";
                }
            }
        }
        public override string ToString()
        {
            return $"SecondClass {text} {text2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass first = new FirstClass();
            SecondClass second = new SecondClass();

            first.MyProperty = "abcd";
            Console.WriteLine(first);

            second.MyProperty = "zxc vbn";
            Console.WriteLine(second);

            second.MyProperty = "zxcvbn";
            Console.WriteLine(second);

            second.MyProperty = "zxcvbn ";
            Console.WriteLine(second);

            second.MyProperty = " zxcvbn ";
            Console.WriteLine(second);
        }
    }
}
