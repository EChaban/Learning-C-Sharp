/*Ќапишите программу, в которой создаетс€ целочисленный массив,
заполн€етс€ случайными числами и после этого значени€ элементов
в массиве сортируютс€ в пор€дке убывани€ значений.*/

using Microsoft.VisualBasic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Homework_1
{
    internal static class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] ints = new int[rnd.Next(10, 50)];
            for (int i = 0; i < ints.Length; i++) ints[i] = rnd.Next(0, 100);

            Array.Sort(ints);
            Array.Reverse(ints);

            string result = "";

            for (int i = 0; i < ints.Length - 1; i++)
            {
                result += ints[i] + ", ";
            }
            result += ints[^1];

            MessageBox.Show(result, "«аголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}