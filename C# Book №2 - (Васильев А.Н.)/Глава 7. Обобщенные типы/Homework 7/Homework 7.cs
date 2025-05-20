/*Напишите программу со статическим обобщенным методом, которо-
му в качестве аргумента передается массив из элементов обобщенного
типа. При вызове метода выполняется сортировка элементов массива
в порядке возрастания/убывания. Для возможности сравнения зна-
чений элементов массива друг с другом (больше/меньше) следует на-
ложить на обобщенный тип ограничение, состоящее в необходимости
реализации интерфейса IComparable. Для сравнения значений обоб-
щенных типов использовать метод CompareTo().*/

using System;
using System.Linq;

namespace Homework_7
{
    internal class Program
    {
        public static (T[], T[]) SortArrayAscendingAndDescending<T>(T[] array) where T : IComparable
        {
            T[] firstMin = new T[array.Length];
            T[] firstMax = new T[array.Length];
            Array.Copy(array, firstMin, array.Length);
            Array.Copy(array, firstMax, array.Length);
            T tmp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (firstMin[j].CompareTo(firstMin[j + 1]) > 0)
                    {
                        tmp = firstMin[j];
                        firstMin[j] = firstMin[j + 1];
                        firstMin[j + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < firstMax.Length - 1; i++)
            {
                for (int j = firstMax.Length - 1; j > i; j--)
                {
                    if (firstMax[j - 1].CompareTo(firstMax[j]) < 0)
                    {
                        tmp = firstMax[j];
                        firstMax[j] = firstMax[j - 1];
                        firstMax[j - 1] = tmp;
                    }
                }
            }

            return (firstMin, firstMax);
        }
        static void Main(string[] args)
        {
            int[] ints = { 2, 1, 3, 5, 4, 7, 6, 8, 10, 9 };
            int[] firstArray = new int[ints.Length];
            int[] secondArray = new int[ints.Length];

            (firstArray, secondArray) = SortArrayAscendingAndDescending(ints);

            Console.WriteLine(String.Join(", ", firstArray));
            Console.WriteLine(String.Join(", ", secondArray));
        }
    }
}
