using System;

namespace Home_Work_1
{
    // The program finds the sum, product and arithmetic mean of three numbers.
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                double firstValue = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double secondValue = double.Parse(Console.ReadLine());

                Console.Write("Enter the third number: ");
                double thirdValue = double.Parse(Console.ReadLine());

                double result = firstValue + secondValue + thirdValue;
                Console.WriteLine("Sum of numbers is " + result);

                result = firstValue * secondValue * thirdValue;
                Console.WriteLine("The product of the numbers is " + result);

                result = (firstValue + secondValue + thirdValue) / 3;
                Console.WriteLine("The arithmetic mean is equal to " + result);

                Console.WriteLine("Press any key to repeat ");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
