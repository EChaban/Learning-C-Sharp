/*Напишите программу, в которой открывается окно с раскрывающим-
ся списком. Список содержит названия цветов (красный, желтый, зе-
леный и так далее). Также окно содержит область, закрашенную тем
цветом, который выбран в списке. При выборе в списке нового цвета
область закрашивается этим цветом автоматически.*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Homework_3
{
    class MyClass: Form
    {
        Label lbl;
        Color color;
        ComboBox list;
        string[] colorNames = { "Синий", "Красный", "Зелёный", "Жёлтый", "Оранжевый", "Фиолетовый", "Розовый", "Коричневый", "Чёрный", "Белый" };
        Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.Pink, Color.Brown, Color.Black, Color.White };


        public MyClass(): base()
        {
            Size = new Size(260, 185);
            StartPosition = FormStartPosition.CenterScreen;

            lbl = new Label();
            lbl.SetBounds(10, 10, 90, 90);
            color = colors[0];
            lbl.BackColor = color;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl);

            list = new ComboBox();
            list.Items.AddRange(colorNames);
            list.Location = new Point(110, 10);
            list.SelectedIndex = 0;
            list.SelectedIndexChanged += OnItemChanged;
            Controls.Add(list);
        }

        private void OnItemChanged(object obj, EventArgs ea)
        {
            // Индекс выбранного в списке элемента:
            int index = list.SelectedIndex;
            // Новое изображение для метки:
            lbl.BackColor = colors[index];
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
