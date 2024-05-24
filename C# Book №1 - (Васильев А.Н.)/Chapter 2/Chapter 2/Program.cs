using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        char[] charWord1 = word1.ToCharArray();
        char[] charWord2 = word2.ToCharArray();
        char[] charWord3 = new char[(charWord1.Length + charWord2.Length)];
        for (int i = 0, i2 = 0; i2 < charWord3.Length; i++)
        {
            if (i < charWord1.Length)
            {
                charWord3[i2] = charWord1[i];
                i2++;
            }
            if (i < charWord2.Length)
            {
                charWord3[i2] = charWord2[i];
                i2++;
            }

        }
        string result;
        return result = String.Concat<char>(charWord3);
    }
}

