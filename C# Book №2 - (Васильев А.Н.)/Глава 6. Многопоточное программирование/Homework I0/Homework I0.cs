using System;
using System.Threading;

class Program
{
    static double result = 1;
    static AutoResetEvent doneEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread childThread = new Thread(CalculateProduct);
        childThread.Start();

        // Ожидаем завершения потока
        doneEvent.WaitOne();

        Console.WriteLine($"Вычисленное произведение: {result:F6}");
        Console.WriteLine($"Точное значение: {2.0 / 3.0:F6}");
    }

    static void CalculateProduct()
    {
        double product = 1;
        double term;
        int n = 2;
        do
        {
            term = (Math.Pow(n, 3) - 1) / (Math.Pow(n, 3) + 1);
            product *= term;
            n++;
        } while (term > 1.0 - 1e-8); // Добавляем до тех пор, пока множитель не близок к 1 с высокой точностью

        result = product;
        doneEvent.Set(); // Сигнал главному потоку
    }
}
