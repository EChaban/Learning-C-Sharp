/*Напишите программу с классом, у которого есть два символьных поля
и метод. Он не возвращает результат, и у него нет аргументов. При вызове
метод выводит в консольное окно все символы из кодовой таблицы,
которые находятся "между" символами, являющимися значениями
полей объекта (из которого вызывается метод) . Например, если полям
объекта присвоены значения 'А' и 'D' , то при вызове метода в консольное
окно должны выводиться все символы от 'А' до 'D' включительно.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class BetweenLetters
    {
        char a = 'a', z = 'z';

        public void GetListLetters()
        {
            for (char i = a; i <= z; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BetweenLetters betweenLetters = new BetweenLetters();
            betweenLetters.GetListLetters();
        }
    }
}
