/*Напишите программу, отображающую окно, в котором внутренняя
часть закрашена желтым цветом. При наведении курсора на область
окна цвет фона меняется на зеленый. При щелчке мышью размеры окна
должны увеличиваться на 10%.*/

using System;
using System.Windows.Forms;
using System.Drawing;

class MyClass : Form
{
    public MyClass(): base()
    {
        FormBorderStyle = FormBorderStyle.FixedSingle;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Обычное окно";
        int size = 300;
        Size = new Size(size, size);
        BackColor = Color.Yellow;
        MouseEnter += (obj, ea) => BackColor = Color.Green;
        MouseLeave += (obj, ea) => BackColor = Color.Yellow;
        MouseClick += (obj, ea) =>
        {
            if (ea.Button == MouseButtons.Left)
            {
                size += (size * 10 / 100);
                Size = new Size(size, size);
            }
            else
            {
                size -= (size * 10 / 100);
                Size = new Size(size, size);
            }
        };
    }
}

class MainClass
{
    [STAThread]
    static void Main()
    {
        Application.Run(new MyClass());
    }
}