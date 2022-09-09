using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class Numbers
{
    static void Main()
    {
        try
        {
            int n = Int32.Parse(Interaction.InputBox("Enter the number", "Programm"));
            int num1 =1;
            int k = 0;
            int sum = 0;
            string text = ""; 
            while (k < n)
            {
                if (num1%5==2 || num1%3 == 1)
                {
                    k++;
                    text += num1+" ";
                    sum += num1;
                    num1++;
                }
                else
                {
                    num1++;
                }
            }
            MessageBox.Show( text+"="+sum, "Programm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
            MessageBox.Show("An error has occurred", "Programm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
