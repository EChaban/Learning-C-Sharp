using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            string result;
            int amount, amount2;
            for (int i = str1.Length; i > 0; i--)
            {
                if (str1.Length % i == 0)
                {
                    result = str1.Substring(0, i);
                    amount = 0;
                    for (int j = 0; j < str1.Length; j += result.Length)
                    {
                        if (result != str1.Substring(j, result.Length)) break;
                        amount++;
                    }
                    if (amount == str1.Length / i)
                    {
                        if (str2.Length % result.Length == 0)
                        {
                            amount2 = 0;
                            for (int k = 0; k < str2.Length; k += result.Length)
                            {
                                if (result != str2.Substring(k, result.Length)) break;
                                amount2++;
                            }
                            if (amount2 == str2.Length / i) return result;
                        }
                    }
                }
            }
            return "";
        }
    }

    internal class LeetCode
    {
        static void Main(string[] args)
        {
            string str1 = "ABABAB";
            string str2 = "ABAB";
            Console.WriteLine("str1 = " + str1 + "and str2 = " + str2);
            Solution solution = new Solution();
            string result = solution.GcdOfStrings(str1, str2);

            Console.WriteLine();
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Должен быть ответ: TAUXX");
        }
    }
}
