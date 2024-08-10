/*Напишите программу с классом, в котором есть текстовое поле и символьное
поле. Значение полям присваивается при создании объекта
класса. В классе должен быть метод, возвращающий результатом массив
из текстовых строк. Такие строки получаются разбиением на подстроки
значения текстового поля. Символ, являющийся индикатором
для разбивки на подстроки, определяется значением символьного поля.
Переопределить в классе метод ToString() так, чтобы он возвращал
текст со значениями полей объекта и подстроки, на которые разбивается
текст из текстового поля.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    class Test
    {
        string text;
        char sym;

        public Test(string text, char sym)
        {
            this.text = text;
            this.sym = sym;
        }

        public string[] SplitText()
        {
            string[] split = text.Split(sym);
            return split;
        }

        public override string ToString()
        {
            string showInfo = text + "\n" + sym + "\n";
            string[] split = SplitText();
            for (int i = 0; i < split.Length; i++)
                showInfo += split[i] + "\n";
            return showInfo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test("Hello evereyone I'm learning C#", 'e');
            Console.WriteLine(test);
        }
    }
}
