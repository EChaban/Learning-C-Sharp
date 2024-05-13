using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    // The program checks the entered number for parity.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is not even.");
            }

            Console.ReadLine();
        }
    }
}
