using System;

namespace Homework_13
{
    internal class Program
    {
        // The method adds elements to the beginning, end, and at the specified index of the array.
        static void ChangeArray(ref int[] array, int addElement, int indexOfArray)
        {
            int[] newArray = new int[array.Length + 2];
            newArray[0] = addElement;
            newArray[newArray.Length - 1] = addElement;

            for (int i = 0; i < array.Length; i++)
                newArray[i + 1] = array[i];

            newArray[indexOfArray] = addElement;

            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            int addElement = 10;
            Console.Write("Enter the number of array element: ");
            int indexOfArray = int.Parse(Console.ReadLine());

            Console.Write("Old array: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");

            Console.WriteLine();

            ChangeArray(ref myArray, addElement, indexOfArray);

            Console.Write("New array: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
