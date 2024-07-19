/*Напишите программу с классом, в котором есть закрытое статическое
целочисленное поле с начальным нулевым значением. В классе должен
быть описан статический метод, при вызове которого отображается текущее
значение статического поля, после чего значение поля увеличивается
на единицу*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Number
    {
        private static int num;

        public static void WriteNum()
        {
            Console.WriteLine(num);
            num++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Number.WriteNum();
            Number.WriteNum();
            Number.WriteNum();
            Number.WriteNum();
            Number.WriteNum();
        }
    }
}
