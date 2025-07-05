/*Напишите программу, в которой описывается класс с тремя полями
(целое число, символ и текст). Создайте объект этого класса, прочитав
значения для его полей из бинарного файла. Файл предварительно со-
здается программой.*/

using System;
using System.IO;

namespace Homework_7
{
    class MyClass
    {
        private int num;
        private char sym;
        private string text;

        public MyClass(BinaryReader br)
        {
            num = br.ReadInt32();
            sym = br.ReadChar();
            text = br.ReadString();
        }

        public void Show()
        {
            Console.WriteLine(num + " " + sym + " " + text);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Программирование\\C#\\Васильев C#\\examples\\date.dat";

            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {
                bw.Write((int)10);
                bw.Write((char)'J');
                bw.Write((string)"Вот такой текст!");
            }

            using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                MyClass myClass = new MyClass(br);
                myClass.Show();
            }
        }
    }
}
