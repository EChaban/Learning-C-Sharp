/**/

namespace Homework_1
{
    internal class Program
    {
        static void SumNums(ref int a, ref int b)
        {
            a += b;
            b += a;
        }


        static void Main()
        {
            int a, b;
            SumNums(ref a, ref b);
            Console.WriteLine("dhfghdfgdfg");
        }
    }
}
