/*Напишите программу, в которой объявляются три переменные типа
int. Первые две переменные получают случайные значения. Область
памяти, выделенная под третью переменную, заполняется следующим
образом: первые два байта копируются из первой переменной, а следую-
щие два байта копируются из второй переменной. Предложите способ
проверки корректности вычислений.*/

using System;

namespace Homework_3
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Random rnd = new Random();
            int n1 = rnd.Next();
            int n2 = rnd.Next();
            int n3 = 0;

            byte* pN1 = (byte*)&n1;
            byte* pN2 = (byte*)&n2;
            byte* pN3 = (byte*)&n3;

            pN3[0] = pN1[0];
            pN3[1] = pN1[1];
            pN3[2] = pN2[2];
            pN3[3] = pN2[3];

            Console.WriteLine(n1);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(pN1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(n2);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(pN2[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(n3);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(pN3[i] + " ");
            }
        }
    }
}
