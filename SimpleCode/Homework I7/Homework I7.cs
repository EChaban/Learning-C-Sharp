using System;


namespace Homework_I7
{
    internal class Program
    {
        // Finds the sum of digits of a number using recursion
        static int SumNumber(int number)
        {
            if (number % 10 == 0) 
                return 0;
            int result = SumNumber(number/10);
            return result += number % 10;
        }

        static void Main(string[] args)
        {
            int number = 56156;
            Console.WriteLine(SumNumber(number));
            Console.ReadKey();
        }
    }
}
