using System;

namespace Homework_4
{
    // The program counts the number of even and odd numbers entered by the user, as well as their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number in the range: ");
            int currentValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number in the range: ");
            int limit = int.Parse(Console.ReadLine());

            uint evenNumbersCount = 0;
            uint oddNumbersCount = 0;
            int sum = 0;

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersCount++;
                }
                sum += currentValue;
                currentValue++;
            }
            Console.WriteLine("Even numbers are " + evenNumbersCount);
            Console.WriteLine("Odd numbers are " + oddNumbersCount);
            Console.WriteLine("Sum of numbers is " + sum);
            Console.ReadKey();
        }
    }
}
