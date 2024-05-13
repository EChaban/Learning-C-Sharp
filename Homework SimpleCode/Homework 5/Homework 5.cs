using System;

namespace Homework_5
{
    internal class Program
    {
        // The program creates triangles with a height entered by the user using nested loops.

        static void Main(string[] args)
        {
            Console.Write("Enter the height of the triangles: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = height; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 1; i <= height; i++)
            {
                for (int j = height-i; j >= 1; j--)
                {
                    Console.Write(" ");
                }

                for (int jBack = 1; jBack<= i; jBack++ )
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 1; i <= height; i++)
            {
                for (int jBack = 1; jBack < i; jBack++)
                {
                    Console.Write(" ");
                }

                for (int j = height + 1 - i; j >= 1; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
