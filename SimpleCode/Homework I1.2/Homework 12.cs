using System;

namespace Homework_12
{
    internal class Program
    {
        // The method "Resize" that changes the number of array elements.
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];

            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };

            Resize(ref myArray, 10);
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}