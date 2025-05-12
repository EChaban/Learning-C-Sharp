/*Напишите программу, в которой в главном потоке целочисленная пе-
ременная через определенные промежутки получает случайное значе-
ние. Два дочерних потока периодически (через определенные промежут-
ки времени) проверяют значение переменной. Первый поток проверяет,
является ли значение переменной нечетным, а второй поток проверяет,
делится ли значение переменной на 3. Если проверка успешная, то соот-
ветствующий поток выводит в консольное окно сообщение.*/

using System;
using System.Threading;

namespace Homework_2
{

    internal class Program
    {
        static int num = 0;
        static readonly object lockObj = new object();
        static bool isRunning = true;

        static void oddCheckerThread()
        {
            while (isRunning)
            {
                int tmp;
                lock (lockObj)
                {
                    tmp = num;
                }

                if (tmp % 2 != 0) Console.WriteLine($"Число {tmp} нечётное");
                Thread.Sleep(700);
            }
        }

        static void divisibleByThreeCheckerThread()
        {
            while (isRunning)
            {
                int tmp;
                lock (lockObj)
                {
                    tmp = num;
                }
                if (tmp % 3 == 0) Console.WriteLine($"Число {tmp} делиться на 3");
                Thread.Sleep(900);
            }
        }


        static void Main(string[] args)
        {
            Random rnd = new Random();
            Thread oddThread = new Thread(oddCheckerThread);
            Thread divThreeThread = new Thread(divisibleByThreeCheckerThread);
            oddThread.Start();
            divThreeThread.Start();

            for (int i = 0; i < 51; i++)
            {
                int tmp = rnd.Next(0, 101);
                lock (lockObj)
                {
                    num = tmp;
                }

                Console.WriteLine($"\"Главный поток\" обновил число на {tmp}");
                Thread.Sleep(1000);
            }

            isRunning = false;
            
            oddThread.Join();
            divThreeThread.Join();

            Console.WriteLine("Программа завершена.");
        }
    }
}
