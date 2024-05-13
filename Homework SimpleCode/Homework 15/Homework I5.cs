using System;

namespace Homework_15
{
    // Array output using recursion
    internal class Program
    {
        static void PrintArray(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.Write(array[i] + "\t");
                PrintArray(array, ++i);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
