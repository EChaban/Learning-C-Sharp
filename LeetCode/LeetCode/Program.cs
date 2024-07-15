using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                string tmp = "";
                tmp = str1;
                str1 = str2;
                str2 = tmp;
            }

            string tmpS1;
            string result = "";
            int count;
            for (int i = 0; i < str1.Length; i++)
            {
                tmpS1 = str1.Substring(0, str1.Length - i);
                if (str2.Length % tmpS1.Length == 0 && str1.Length % tmpS1.Length == 0)
                {
                    count = 0;
                    for (int j = 0; j < str2.Length; j += tmpS1.Length)
                    {
                        if (tmpS1 != str2.Substring(j, tmpS1.Length)) break;
                        count++;
                    }
                    if (count == (str2.Length / tmpS1.Length))
                    {
                        result = tmpS1;
                        break;
                    }
                }
            }
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
            string str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
            Console.WriteLine("str1 = " + str1 + "and str2 = " + str2);
            Solution solution = new Solution();
            string result = solution.GcdOfStrings(str1, str2);

            Console.WriteLine();
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Должен быть ответ: TAUXX");
        }
    }
}
