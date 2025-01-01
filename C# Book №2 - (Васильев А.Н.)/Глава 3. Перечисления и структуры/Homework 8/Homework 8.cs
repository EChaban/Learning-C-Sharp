/*Напишите программу, в которой объявлены две структуры. У одной
структуры есть текстовое поле, а у другой структуры есть символьное
поле. В первой структуре (с текстовым полем) должен быть метод с це-
лочисленным аргументом, который результатом возвращает экземпляр
второй структуры (с символьным полем). Значение символьного поля
экземпляра-результата определяется как символ из текста (поле экзем-
пляра, из которого вызывается метод) с индексом, определяемым аргу-
ментом метода.*/

using System;

namespace Homework_8
{
    struct TextStruct
    {
        string text;

        public TextStruct(string t)
        {
            text = t;
        }

        public SymbStruct GetSymb(int num)
        {
            return new SymbStruct(text[num]);
        }
    }

    struct SymbStruct
    {
        char symb;

        public SymbStruct(char s)
        {
            symb = s;
        }
        public char Property { get { return symb; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TextStruct text = new TextStruct("Hello");

            Console.WriteLine(text.GetSymb(2).Property);
        }
    }
}
