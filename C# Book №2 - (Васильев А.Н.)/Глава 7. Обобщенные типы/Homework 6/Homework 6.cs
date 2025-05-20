/*Напишите программу, в которой есть статический обобщенный метод.
Аргументом методу передается массив из элементов обобщенного типа.
Результатом метод возвращает значение наибольшего/наименьшего
элемента в массиве. Чтобы можно было сравнивать значения обобщен-
ного типа, на этот обобщенный тип следует наложить ограничение: тип
должен быть таким, что реализует интерфейс IComparable. Если так,
то для сравнения значений может использоваться метод CompareTo().
Метод вызывается из одного объекта (первый объект) обобщенного
типа, а аргументом ему передается другой (второй) объект обобщенно-
го типа (сравниваемые объекты). Результатом метода является целое
число. Отрицательное число возвращается, если первый объект «мень-
ше» второго. Положительное число возвращается, если первый объект
«больше» второго. Если объекты равны друг другу, то результатом мето-
да CompareTo() является нулевое значение.*/

using System;

namespace Homework_6
{
    internal class Program
    {
        public static (T, T) SearchMaxMin<T>(T[] array) where T : IComparable
        {
            T tmp;
            T[] tmpArray = new T[array.Length];
            Array.Copy(array, tmpArray, array.Length);

            for (int i = 0; i < tmpArray.Length - 1; i++)
            {
                for (int j = 0; j < tmpArray.Length - 1 - i; j++)
                {
                    if (tmpArray[j].CompareTo(tmpArray[j + 1]) > 0)
                    {
                        tmp = tmpArray[j];
                        tmpArray[j] = tmpArray[j + 1];
                        tmpArray[j + 1] = tmp;
                    }
                }
            }
            return (tmpArray[tmpArray.Length - 1], tmpArray[0]);
        }

        static void Main(string[] args)
        {
            int[] ints = { 6, 1, 2, 3, 4, 5, 8, 9, 7 };
            int max, min;
            (max, min) = SearchMaxMin(ints);
            Console.WriteLine($"{max} {min}");
        }
    }
}