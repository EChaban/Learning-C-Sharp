using System;
using System.Threading;

class Program
{
    static double result = 0;
    static AutoResetEvent doneEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread childThread = new Thread(CalculateSum);
        childThread.Start();

        // Ожидаем завершения потока
        doneEvent.WaitOne();

        Console.WriteLine($"Вычисленная сумма: {result:F6}");
        Console.WriteLine($"Точное значение: {3 * Math.Exp(2) - 1:F6}");
    }

    static void CalculateSum()
    {
        double sum = 0;
        double term;
        int n = 1;
        do
        {
            term = Math.Pow(2, n) * (n + 1) / Factorial(n);
            sum += term;
            n++;
        } while (term > 1e-8);

        result = sum;
        doneEvent.Set(); // Сигнал главному потоку
    }

    static double Factorial(int n)
    {
        double f = 1;
        for (int i = 2; i <= n; i++)
        f *= i;
        return f;
    }
}
