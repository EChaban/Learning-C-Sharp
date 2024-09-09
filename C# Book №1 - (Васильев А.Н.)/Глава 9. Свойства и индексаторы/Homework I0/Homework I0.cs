/*Напишите программу с классом, в котором есть текстовый массив.
Опишите в классе одномерный и двумерный индексаторы. Одномерный
индексатор позволяет прочитать элемент текстового массива и присвоить
новое значение элементу текстового массива. Двумерный индексатор
позволяет прочитать символ в элементе текстового массива (первый
индекс определяет элемент в текстовом массиве, а второй индекс определяет
символ в тексте). Предусмотрите циклическую перестановку индексов
в случае, если они выходят за верхнюю допустимую границу.*/

/*string tmp = words[i];
return tmp[j % tmp.Length];*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    internal class Program
    {
        class MyClass
        {
            private string[] words;

            public MyClass(string[] words)
            {
                this.words = words;
            }

            public string this[int i]
            {
                get { return words[i]; }
                set { words[i] = value; }
            }

            public char this[int i, int j]
            {
                get { 
                    return words[i][j % words[i].Length];
                }
                set {
                    char[] tmp = words[i].ToCharArray();
                    tmp[j % tmp.Length] = value;
                    string newWord = new string(tmp);
                    words[i] = newWord;
                }
            }
        }
        static void Main(string[] args)
        {
            string[] words = { "Привет", "продолжаем", "изучать", "C#" };

            MyClass obj = new MyClass(words);

            Console.WriteLine(obj[1]);
            obj[1] = "continue";
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[3, 1]);
            obj[3, 1] = '$';
            Console.WriteLine(obj[3, 1]);
        }
    }
}
