/*Напишите программу, в которой создаётся одномерный массив из 11 целочисленных элементов. Массив заполняется степенями двойки. 
При заполнении массива учесть, что начальный элемент равен 1, а каждый следующий больше предыдущего в 2 раза. 
Отобразить массив в консольном окне в прямом и обратном порядке. Размер массива задаётся переменной.
*/

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 11;
            int[] nums = new int[size];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Math.Pow(2, i));
            }

            foreach (int i in nums) Console.Write(i + " ");

            Console.WriteLine();
            Array.Reverse(nums);

            foreach (int i in nums) Console.Write(i + " ");
        }
    }
}
