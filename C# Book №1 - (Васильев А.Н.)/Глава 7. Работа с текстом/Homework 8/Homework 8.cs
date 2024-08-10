/*Напишите программу с классом, у которого есть текстовое поле. Значение
текстовому полю присваивается при создании объекта класса.
Также в классе должен быть метод, позволяющий вставить подстроку
в текст из текстового поля. Аргументами методу передается подстрока
для вставки в текст, а также индекс позиции, начиная с которой выполняется
вставка. Переопределить в классе метод ToString() так, чтобы
он возвращал значением текст из текстового поля.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Text
    {
        string field;

        public Text(string text)
        {
            field = text;
        }

        public void InsertText(string text, int index)
        {
            string newField = "";
            for (int i = 0; i < index; i++)
                newField += field[i];

            for (int i = 0; i < text.Length; i++)
                newField += text[i];

            for (int i = index; i < field.Length; i++)
                newField += field[i];

            field = newField;
        }

        public override string ToString()
        {
            return field;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("Hello world, I am learning C#");
            Console.WriteLine(text);
            Console.WriteLine();

            text.InsertText(" everyone in the", 5);
            Console.WriteLine(text);
        }
    }
}
