/*Напишите программу с классом, у которого есть символьное и целочисленное поле. 
В классе должны быть описаны версии конструктора с двумя аргументами (целое число и символ - определяют значения полей), 
а также с одним аргументом типа douЬle. В последнем случае
действительная часть аргумента определяет код символа (значение символьного поля), 
а дробная часть (с учетом десятых и сотых) определяет
значение целочисленного поля. Например, если аргументом передается
число 65.1267, то значением символьного поля будет символ 'А' с кодом
65, а целочисленное поле получит значение 12 (в дробной части учитываются только десятые и сотые).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Test
    {
        char _sym;
        int _num;

        public Test(char sym, int num)
        {
            _sym = sym;
            _num = num;
            Console.WriteLine("Значения полей (1ый конструктор): " + _sym + " и " + _num);
        }

        public Test(double num)
        {
            _sym = (char)Math.Truncate(num);
            string tmp = Convert.ToString(Math.IEEERemainder(num, _sym));
            if (tmp.Length > 3)
            {
                _num = Convert.ToInt32(tmp.Substring(2, 2));
            }
            else _num = Convert.ToInt32(tmp.Substring(2, 1));

            Console.WriteLine("Значения полей (2ой конструктор): " + _sym + " и " + _num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test('A', 12);
            Test test2 = new Test((double)65.1234);
        }
    }
}
