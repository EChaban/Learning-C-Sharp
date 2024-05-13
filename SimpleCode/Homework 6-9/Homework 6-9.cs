using System;

namespace Homework_6_9
{
    internal class Program
    {
        /*  The user fills the array with the keyboard
            The program outputs the array in reverse order
            Finds the sum of even numbers in an array
            Finds the smallest number in an array   */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int amountElements = int.Parse(Console.ReadLine());
            int[] array = new int[amountElements];
            int indexArray = 0;
            
            for(int i = 0; i < amountElements; ++i)
            {
                Console.WriteLine("Enter the element #" + ++indexArray);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The resulting array is in reverse order: ");
            for (int i = amountElements-1 ; i >= 0; i--)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("");

            int sum = 0;
            for(int i = 0; i < amountElements; ++i)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.Write("Sum of even numbers in the array: " + sum);
            Console.WriteLine("");

            int smallestNumber = array[0];
            for (int i = 1; i < amountElements; i++)
            {
                if (smallestNumber > array[i])
                {
                    smallestNumber = array[i];
                }
            }
            Console.Write("The smallest number is: " + smallestNumber);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
