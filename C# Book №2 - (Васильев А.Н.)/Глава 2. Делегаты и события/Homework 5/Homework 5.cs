/*Напишите программу, в которой с помощью делегатов и анонимных
методов (лямбда-выражений) создается экземпляр делегата, который
вызывается без аргументов, а результатом возвращает число из после-
довательности Фибоначчи — при каждом новом вызове получаем новое
число в последовательности. В последовательности Фибоначчи первые
два числа равны единице, а каждое следующее число равно сумме двух
предыдущих.*/

using System;

delegate int FibonacciDelegate();

class Fibonacci
{
    private int firstNum = 0; // Начальное значение 0
    private int secondNum = 1; // Начальное значение 1

    public FibonacciDelegate GetFibonacci;

    public Fibonacci()
    {
        // Анонимный метод для вычисления чисел Фибоначчи
        GetFibonacci = delegate ()
        {
            int newNum = firstNum + secondNum; // Следующее число
            firstNum = secondNum;             // Обновляем предыдущие числа
            secondNum = newNum;               // Обновляем текущее число
            return firstNum;                  // Возвращаем текущее число
        };
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Fibonacci obj = new Fibonacci();

        // Выводим несколько чисел последовательности Фибоначчи
        Console.WriteLine(obj.GetFibonacci()); // 1
        Console.WriteLine(obj.GetFibonacci()); // 1
        Console.WriteLine(obj.GetFibonacci()); // 2
        Console.WriteLine(obj.GetFibonacci()); // 3
        Console.WriteLine(obj.GetFibonacci()); // 5
        Console.WriteLine(obj.GetFibonacci()); // 8
    }
}

