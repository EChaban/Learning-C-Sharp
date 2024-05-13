using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    // Two calculators, the first uses "switch", the second uses "if"
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter 1 to use \"the switch calculator\"");
                Console.WriteLine("Enter 2 to use \"the if calculator\"");
                string answer = Console.ReadLine();

                Console.Write("Enter the first number: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the operation \"+, -, *, /\": ");
                char operation = char.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double number2 = double.Parse(Console.ReadLine());
                double result;

                switch (answer)
                {
                    case "1":
                        Console.WriteLine(" ");
                        Console.WriteLine("You chose \"the switch calculator\"");
                        switch (operation)
                        {
                            case '+':
                                result = number1 + number2;
                                Console.WriteLine("The result is " + result);
                                break;
                            case '-':
                                result = number1 - number2;
                                Console.WriteLine("The result is " + result);
                                break;
                            case '*':
                                result = number1 * number2;
                                Console.WriteLine("The result is " + result);
                                break;
                            case '/':
                                result = number1 / number2;
                                Console.WriteLine("The result is " + result);
                                break;
                            default:
                                Console.WriteLine("I don't know this operation");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("You chose \"the if calculator\"");
                        if (operation == '+')
                        {
                            result = number1 + number2;
                            Console.WriteLine("The result is " + result);
                        }
                        else if (operation == '-')
                        {
                            result = number1 - number2;
                            Console.WriteLine("The result is " + result);
                        }
                        else if (operation == '*')
                        {
                            result = number1 * number2;
                            Console.WriteLine("The result is " + result);
                        }

                        else if (operation == '/')
                        {
                            result = number1 / number2;
                            Console.WriteLine("The result is " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("You entered the wrong number");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Press any button to restart.");
                Console.ReadKey();
            }
        }
    }
}
