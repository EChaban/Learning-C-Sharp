/*Напишите программу, в которой отображается окно со списком выбо-
ра. В списке выбора представлены названия шрифтов. Также окно содер-
жит раскрывающийся список с названиями цветов (красный, зеленый,
синий и так далее). Окно содержит область с текстом. При выборе цвета
или названия шрифта этот цвет или шрифт применяются для отображе-
ния текста.*/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Homework_7
{
    class MyClass: Form
    {
        ComboBox combo;
        ListBox list;
        TextBox text;

        string[] colorsName = { "Красный", "Зеленый", "Синий", "Желтый", "Черный" };
        Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Black };

        string[] fontNames = { "Arial", "Times New Roman", "Courier New", "Verdana", "Tahoma" };
        Font[] fonts = new Font[]
        {
            new Font("Arial", 12, FontStyle.Regular),
            new Font("Times New Roman", 12, FontStyle.Regular),
            new Font("Courier New", 12, FontStyle.Regular),
            new Font("Verdana", 12, FontStyle.Regular),
            new Font("Tahoma", 12, FontStyle.Regular)
        };

        public MyClass(): base()
        {

            text = new TextBox();
            text.Multiline = true;
            text.SetBounds(10, 10, 200, 100);
            text.Text = "Здесь можно ввести текст!";
            text.Font = fonts[0];
            text.ForeColor = colors[0];
            Controls.Add(text);

            list = new ListBox();
            list.Items.AddRange(fontNames);
            list.SelectedIndex = 0;
            list.Location = new Point(10, text.Bottom + 10);
            list.SelectedIndexChanged += (a, b) =>
            {
                int index = list.SelectedIndex;
                text.Font = fonts[index];
            };
            Controls.Add(list);

            combo = new ComboBox();
            combo.Location = new Point(list.Right + 10, list.Top);
            combo.Items.AddRange(colorsName);
            combo.SelectedIndex = 0;
            combo.SelectedIndexChanged += (a, b) =>
            {
                int index = combo.SelectedIndex;
                text.ForeColor = colors[index];
            };
            Controls.Add(combo);
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MyClass());
        }
    }
}
