/*Напишите программу, в которой решается квадратное уравнение
Ax2 + Bx + C = 0. В общем случае уравнение имеет два решения
x = –B±√B2 – 4AC / 2A. Предложите схему обработки исключительных ситуа-
ций. Для вычисления квадратного корня можно использовать статиче-
ский метод Sqrt() из класса Math.*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Решение квадратного уравнения Ax^2 + Bx + C = 0");

            Console.Write("Введите A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите C: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                throw new ArgumentException("Коэффициент A не может быть равен нулю (это не квадратное уравнение).");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {x}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите числовые значения.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }
    }
}

