/*Напишите программу, содержащую статический метод с тремя дей-
ствительными (тип double) аргументами. Результатом статического
метода является ссылка на метод, вычисляющий квадратичный трех-
член с коэффициентами, определяемыми аргументами статического
метода. Другими словами, если статический метод вызывается с число-
выми аргументами a, b и c, то результатом является ссылка на метод,
который для аргумента x типа double результатом вычисляет значение
выражения a*x*x+b*x+c.*/

using System;

namespace Homework_9
{
    internal class Program
    {
        delegate double QuadraticFunction(double x);

        static QuadraticFunction EvaluateQuadratic(double a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }
        static void Main(string[] args)
        {
            QuadraticFunction myDelegate = EvaluateQuadratic(2, 3, 4);
            Console.WriteLine(myDelegate(5));
        }
    }
}
