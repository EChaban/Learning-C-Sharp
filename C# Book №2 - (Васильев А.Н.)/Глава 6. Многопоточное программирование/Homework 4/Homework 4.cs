/*Напишите программу, в которой два потока заполняют целочислен-
ный массив. Один поток заполняет массив с начала до конца числами,
являющимися степенями двойки. Другой поток
заполняет массив с конца до начала числами, являющимися степенями тройки.*/

using System;
using System.Threading;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] pows = new double[10];

            Thread binaryPower = new Thread(() =>
            {
                for (int i = 0; i < pows.Length / 2; i++)
                {
                    pows[i] = Math.Pow(2, i);
                }
            });

            Thread ternaryPower = new Thread(() =>
            {
                for (int i = pows.Length - 1, power = 0; i > pows.Length / 2 - 1; i--, power++)
                {
                    pows[i] = Math.Pow(3, power);
                }
            });

            binaryPower.Start();
            ternaryPower.Start();

            Console.WriteLine(string.Join(", ",pows));
        }
    }
}
