/*Напишите программу, в которой отображается окно с текстовой мет-
кой и тремя кнопками. В текстовой метке содержится число (начальное
значение — нулевое). Щелчок по одной из меток приводит к увеличе-
нию значения числа на единицу. Щелчок по другой кнопке приводит
к уменьшению значения числа на единицу. Щелчок по третьей кнопке
приводит к закрытию окна.*/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Homework_2
{
    class MyClass: Form
    {
        Label lbl;
        int num = 0;
        Button increase, decrease, exit;

        public MyClass(): base()
        {
            StartPosition = FormStartPosition.CenterScreen;

            lbl = new Label();
            lbl.Location = new Point(10, 10);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Text = num.ToString();
            lbl.Width = this.ClientSize.Width - 20;
            lbl.Height = 50;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Arial", 25, FontStyle.Bold);
            Controls.Add(lbl);

            increase = new Button();
            increase.Bounds = new Rectangle(lbl.Left, lbl.Bottom + 10, lbl.Width / 3 - 6, lbl.Height);
            increase.Text = "+";
            increase.Font = new Font("Arial", 20, FontStyle.Bold);
            increase.TextAlign = ContentAlignment.MiddleCenter;
            increase.Click += ClickButton;
            Controls.Add(increase);

            decrease = new Button();
            decrease.Bounds = new Rectangle(increase.Right + 10, lbl.Bottom + 10, lbl.Width / 3 - 6, lbl.Height);
            decrease.Text = "-";
            decrease.Font = new Font("Arial", 20, FontStyle.Bold);
            decrease.TextAlign = ContentAlignment.MiddleCenter;
            decrease.Click += ClickButton;
            Controls.Add(decrease);

            exit = new Button();
            exit.Bounds = new Rectangle(decrease.Right + 10, lbl.Bottom + 10, lbl.Width / 3 - 6, lbl.Height);
            exit.Text = "Exit";
            exit.Font = new Font("Arial", 20, FontStyle.Bold);
            exit.TextAlign = ContentAlignment.MiddleCenter;
            exit.Click += ClickButton;
            Controls.Add(exit);
        }

        void ClickButton(object obj, EventArgs ea)
        {
            Button btn = (Button)obj;
            if (btn.Text == "+")
            {
                num++;
                lbl.Text = num.ToString();
            }
            else if (btn.Text == "-")
            {
                num--;
                lbl.Text = num.ToString();
            }
            else if (btn.Text == "Exit") Application.Exit();
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
