using System;
using System.Reflection;

namespace Homework_I4
{
    internal class Program
    {
        // The method removes elements at the beginning, end, and at the specified array index.
        static void RemoveElemet(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length-1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < newArray.Length; i++)
                newArray[i] = array[i+1];

            array = newArray;
        }

        static void RemoveFirstElemet(ref int[] array)
        {
            RemoveElemet(ref array, 0);
        }

        static void RemoveLastElemet(ref int[] array)
        {
            RemoveElemet(ref array, array.Length-1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Console.Write("Old array: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");
            Console.WriteLine();

            RemoveElemet(ref myArray, 4);
            RemoveFirstElemet(ref myArray);
            RemoveLastElemet (ref myArray);

            Console.Write("New array: ");
            for (int i = 0;i < myArray.Length;i++) 
                Console.Write(myArray[i] + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
