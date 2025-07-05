/*Напишите программу, в которой считывается содержимое текстового
файла и создается новый текстовый файл. В новый текстовый файл за-
носится текст из исходного текстового файла, но все пробелы заменяют-
ся подчеркиваниями, а заглавные буквы заменяются строчными.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Программирование\\C#\\Васильев C#\\examples\\";
            BinaryReader reader = new BinaryReader(new FileStream(path + "MyText.txt", FileMode.Open));
            BinaryWriter writer = new BinaryWriter(new FileStream(path + "NewMyText.txt", FileMode.Create));

            List<char> list = new List<char>();
            char symb;

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                symb = reader.ReadChar();
                list.Add(symb);  
            }
            reader.Close();

            List<char> newList = list.Select(c => c == ' ' ? '_' : char.ToLower(c)).ToList();

            for (int i = 0; i < newList.Count; i++)
            {
                writer.Write(newList[i]);
            }
            writer.Close();
        }
    }
}
