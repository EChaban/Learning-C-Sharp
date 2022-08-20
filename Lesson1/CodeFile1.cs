using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class Form
{
    static void Main()
    {
        string name = Interaction.InputBox("What's your name?", "Name");
        string surname = Interaction.InputBox("What's your last name?", "Last name");
        int years = Int32.Parse(Interaction.InputBox("What is your year of birth?", "Year of birth"));
        int years2 = 2022 - years;
        MessageBox.Show("Is it right? " + name + " " + surname + " " + years2 + " years old.", "Your form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}