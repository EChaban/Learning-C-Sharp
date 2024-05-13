using System;

namespace Homework_I6
{
    // Find the sum of array elements using recursion
    internal class Program
    {
        static void SumArray(int[]array, ref int sum, int i = 0)
        {
            if (i < array.Length)
            {
                sum += array[i];
                SumArray(array, ref sum, ++i);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            SumArray(myArray, ref sum);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
