/*Напишите программу, в которой отображается окно с закрашенной
областью. Для этой области есть контекстное меню с названиями цветов
(красный, желтый, зеленый и так далее). При выборе команды из кон-
текстного меню область закрашивается соответствующим цветом.*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Homework_8
{
    class MyClass : Form
    {
        Label lbl;
        ContextMenuStrip cms;
        string[] colorsName = { "Красный", "Зеленый", "Синий", "Желтый", "Черный" };
        Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Black };

        public MyClass(): base()
        {
            cms = new ContextMenuStrip();
            for (int i = 0; i < colorsName.Length; i++)
            {
                int index = i;
                cms.Items.Add(colorsName[i]);
                cms.Items[i].Click += (obj, ea) =>
                {
                    lbl.BackColor = colors[index];
                };
            }

            lbl = new Label();
            lbl.SetBounds(10, 10, 100, 100);
            lbl.BackColor = colors[0];
            lbl.ContextMenuStrip = cms;
            Controls.Add(lbl);
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
