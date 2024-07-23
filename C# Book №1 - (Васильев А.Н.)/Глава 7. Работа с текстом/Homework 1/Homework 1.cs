/**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "text";
            string b = "Text";
            
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(String.Equals(a, b, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(a.ToLower() == b.ToLower());


        }
    }
}
