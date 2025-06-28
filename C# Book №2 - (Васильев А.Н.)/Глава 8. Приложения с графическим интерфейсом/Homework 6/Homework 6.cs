/*Напишите программу, в которой отображается окно с изображени-
ем и двумя кнопками. Имеется несколько изображений, которые по-
следовательно циклически отображаются в окне при щелчке по кноп-
кам. При щелчке по одной кнопке появляется следующее изображение
в последовательности, а при щелчке по другой кнопке отображается пре-
дыдущее изображение в последовательности.*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Homework_6
{
    class MyClass: Form
    {
        Label pict;
        Image image;
        Button prev, next;
        CheckBox slide;
        string path = "C:\\Users\\evgen\\OneDrive\\Рабочий стол\\animals\\";
        string[] animals = {"bear.jpeg", "fox.jpeg", "raccoon.jpeg", "squirrel.jpeg"};
        int index = 0;
        private Timer slideshowTimer;

        public MyClass(): base()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            pict = new Label();
            image = Image.FromFile(path + animals[index]);
            pict.Location = new Point(10, 10);
            pict.ImageAlign = ContentAlignment.MiddleCenter;
            pict.Image = image;
            pict.Size = image.Size;
            Controls.Add(pict);

            prev = new Button();
            prev.Left = pict.Left;
            prev.Top = pict.Bottom + 10;
            prev.Text = "Предыдущая\nкартинка";
            prev.Width = 100;
            prev.Height = 50;
            prev.Click += ClickOnButton;
            Controls.Add(prev);

            next = new Button();
            next.Left = prev.Right + 10;
            next.Top = pict.Bottom + 10;
            next.Text = "Следующая\nкартинка";
            next.Width = 100;
            next.Height = 50;
            next.Click += ClickOnButton;
            Controls.Add(next);

            slide = new CheckBox();
            slide.Text = "Слайд-шоу";
            slide.Left = pict.Left + 10;
            slide.Top = prev.Bottom + 10;
            slide.Click += ClickOnCheckBox;
            Controls.Add(slide);

            slideshowTimer = new Timer();
            slideshowTimer.Interval = 1000;
            slideshowTimer.Tick += (s, e) =>
            {
                index = (index + 1) % animals.Length;
                pict.Image = Image.FromFile(path + animals[index]);
            };
        }

        void ClickOnButton(object obj, EventArgs ea)
        {
            Button btn = (Button)obj;
            if(btn.Text == "Предыдущая\nкартинка")
            {
                index = (index - 1 + animals.Length) % animals.Length;
                pict.Image = Image.FromFile(path + animals[index]);
            }
            else
            {
                index = (++index) % animals.Length;
                pict.Image = Image.FromFile(path + animals[index]);
            }
        }

        void ClickOnCheckBox(object obj, EventArgs ea)
        {
            CheckBox chk = (CheckBox)obj;
            if (chk.Checked)
                slideshowTimer.Start();
            else
                slideshowTimer.Stop();
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
