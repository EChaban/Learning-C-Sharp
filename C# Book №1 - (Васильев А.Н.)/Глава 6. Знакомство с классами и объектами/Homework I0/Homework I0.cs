/*Напишите программу со статическим методом для вычисления косинуса. 
В классе также должны быть статические методы для вычисления 
гиперболического синуса и гиперболического косинуса.*/

using System;

class Program
{
    class SinCos
    {
        public static double CalculateCosine(double x, int terms)
        {
            double result = 1.0;
            double term = 1.0;
            for (int n = 1; n < terms; n++)
            {
                term *= -x * x / (2 * n * (2 * n - 1));
                result += term;
            }
            return result;
        }

        public static double CalculateSinh(double x, int terms)
        {
            double result = x;
            double term = x;
            for (int n = 1; n < terms; n++)
            {
                term *= x * x / ((2 * n) * (2 * n + 1));
                result += term;
            }
            return result;
        }

        public static double CalculateCosh(double x, int terms)
        {
            double result = 1.0;
            double term = 1.0;
            for (int n = 1; n < terms; n++)
            {
                term *= x * x / (2 * n * (2 * n - 1));
                result += term;
            }
            return result;
        }
    }


    static void Main()
    {
        double x = 1.0; // Значение x для вычисления sh(x) и ch(x)
        int terms = 10; // Количество членов ряда

        double cosX = SinCos.CalculateCosine(x, terms);
        double sinhX = SinCos.CalculateSinh(x, terms);
        double coshX = SinCos.CalculateCosh(x, terms);

        Console.WriteLine($"cos({x}) = {cosX}");
        Console.WriteLine($"sinh({x}) = {sinhX}");
        Console.WriteLine($"cosh({x}) = {coshX}");
    }
}