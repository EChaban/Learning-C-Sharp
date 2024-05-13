using System;

namespace Home_Work_1._2
{
    // The program converts dollars into euros and rubles.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dollar amount: ");

            while (true)
            {
                double USD = Convert.ToDouble(Console.ReadLine());
                double UsdToEur = 0.91;
                double UsdToRub = 90.90;

                Console.WriteLine("USD to EUR: " + USD * UsdToEur + "$");
                Console.WriteLine("USD to RUB: " + USD * UsdToRub + "P");

                Console.WriteLine("Press any key to repeat the operation");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
