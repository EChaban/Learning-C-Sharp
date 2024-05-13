using System;

namespace Homework_I1
{
    internal class Program
    {
        // The program to find the index of an array element, the method should return the index of the first element found.
        static string SearchIndex(int[] nameArray, int elementArray)
        {
            string result = "missing";
            for (int i = 0; i < nameArray.Length; i++)
            {
                if (nameArray[i] == elementArray)
                {
                    return result = Convert.ToString(i);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(100);
            }

            Console.WriteLine("The created array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Enter the number for searching: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("The index of the entered number is " + SearchIndex(myArray, number));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
