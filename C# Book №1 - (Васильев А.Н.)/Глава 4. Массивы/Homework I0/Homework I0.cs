/*Напишите программу, в которой создается двумерный числовой массив
и этот массив заполняется "змейкой": 
сначала первая строка (слева направо), 
затем последний столбец (сверху вниз), 
последняя строка (справа налево), 
первый столбец (снизу вверх), 
вторая строка (слева направо) и так далее.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] snake = new int[rnd.Next(2,11), rnd.Next(2, 11)];
            int lastValue = snake.GetLength(0) * snake.GetLength(1);
            int count = 1;


            int rows = snake.GetLength(0), cols = snake.GetLength(1);
            for (int i = 0, j = 0, sC = 0, sR = 1; true; j++, i++, rows--, cols--, sC++, sR++)
            {
                while (j < cols)
                {
                    snake[i, j] = count;
                    count++;
                    j++;
                }
                if (count > lastValue) break;

                j--;
                i++;
                while (i < rows)
                {
                    snake[i, j] = count;
                    count++;
                    i++;
                }
                if (count > lastValue) break;

                i--;
                j--;
                while (j >= sC)
                {
                    snake[i, j] = count;
                    count++;
                    j--;
                }
                if (count > lastValue) break;

                j++;
                i--;
                while (i >= sR)
                {
                    snake[i, j] = count;
                    count++;
                    i--;
                }
                if (count > lastValue) break;
            }

            for (int y = 0; y < snake.GetLength(0); y++)
            {
                for (int x = 0; x < snake.GetLength(1); x++)
                {
                    Console.Write(snake[y, x] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
