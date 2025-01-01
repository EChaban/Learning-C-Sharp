/*Напишите программу, в которой есть структура с символьным полем.
Также в программе должен быть статический метод, аргументом кото-
рому передается текстовое значение. Результатом метод возвращает
массив из экземпляров структуры. Размер массива определятся длиной
текста. Значения символьных полей экземпляров структуры в массиве
задаются символами из текста. Предложите метод, которому в качестве
аргумента передается массив из экземпляров структуры, а результатом
метод возвращает текстовую строку, состоящую из символьных значе-
ний полей экземпляров в массиве.*/

using System;

namespace Homework_7
{
    struct MyStruct
    {
        char symb;

        public override String ToString()
        {
            return symb+"";
        }

        public static MyStruct[] GetArray(string text)
        {
            MyStruct[] structArray = new MyStruct[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                structArray[i].symb = text[i];
            }
            return structArray;
        }

        public static string GetText(MyStruct[] structArray)
        {
            string text = "";
            for (int i = 0; i < structArray.Length; i++)
            {
                text += structArray[i].symb;
            }
            return text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct[] sArray = MyStruct.GetArray("Hello");
            foreach (MyStruct s in sArray)
            {
                Console.Write(s.ToString());
            }
            Console.WriteLine();

            string text = MyStruct.GetText(sArray);
            Console.WriteLine(text);
        }
    }
}
