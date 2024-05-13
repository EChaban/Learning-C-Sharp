using System;

namespace Homework_10
{
    internal class Program
    {
        // The program displays a string on the screen. The symbols that make up the string and their number are entered by the user.
        static void PrintLine (char symbol, uint symbolCount)
        {
            for(int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter the symbol: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter the number of symbols: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolCount);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
