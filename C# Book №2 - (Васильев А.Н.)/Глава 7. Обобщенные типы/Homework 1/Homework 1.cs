/*Напишите программу, в которой есть обобщенный статический метод
с двумя аргументами обобщенного типа. При вызове метода аргументы
должны обмениваться значениями.*/

using System;

namespace Homework_1
{
    internal class Program
    {
        static (T, T) Swap<T>( T firstValue,  T secondValue)
        {
            T tmp;
            tmp = firstValue;
            firstValue = secondValue;
            secondValue = tmp;
            return (firstValue, secondValue);
        }
        static void Main(string[] args)
        {
            int firstInt = 10, secondInt = 20;
            char firstChar = 'a', secondChar = 'b' ;
            string firstString = "first", secondString = "second";

            Console.WriteLine($"firstInt = {firstInt}, secondInt = {secondInt}");
            Console.WriteLine($"firstChar = {firstChar}, secondChar = {secondChar}");
            Console.WriteLine($"firstString = {firstString}, secondString = {secondString}");
            Console.WriteLine();

            (firstInt, secondInt) = Swap(firstInt, secondInt);
            (firstChar, secondChar) = Swap(firstChar, secondChar);
            (firstString, secondString) = Swap(firstString, secondString);

            Console.WriteLine($"firstInt = {firstInt}, secondInt = {secondInt}");
            Console.WriteLine($"firstChar = {firstChar}, secondChar = {secondChar}");
            Console.WriteLine($"firstString = {firstString}, secondString = {secondString}");
        }
    }
}
