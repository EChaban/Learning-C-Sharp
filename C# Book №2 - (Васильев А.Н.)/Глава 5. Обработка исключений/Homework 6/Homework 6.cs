/*Напишите программу, содержащую статический метод, не воз-
вращающий результат. Аргументом методу передается целое чис-
ло. Если число четное, то метод генерирует исключение класса
ArithmeticException, а если число нечетное, то генерируется ис-
ключение класса OverflowException. В главном методе выполняется
оператор цикла, в котором за каждый цикл пользователь вводит целое
число, оно передается аргументом методу. Организовать обработку со-
бытий таким образом, чтобы в результате появлялось сообщение о том,
четное число или нечетное. Оператор цикла должен завершать работу,
если пользователь вводит не число.*/

using System;

class Program
{
    static void CheckNumber(int number)
    {
        if (number % 2 == 0)
        {
            throw new ArithmeticException("Четное число.");
        }
        else
        {
            throw new OverflowException("Нечетное число.");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число (или любой другой символ для выхода): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ввод не является числом. Завершение работы.");
                break;
            }

            try
            {
                CheckNumber(number);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}
