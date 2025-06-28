/*Напишите программу, в которой отображается окно с двумя текстовы-
ми полями. Предполагается, что в эти текстовые поля вводятся целочис-
ленные значения. Кроме полей, в окне размещена метка, в которой содер-
жится информация о том, какое из двух чисел больше/меньше или что
числа равны друг другу. Информация в метке обновляется автоматически
при изменении содержимого полей. Если хотя бы в одном из полей указа-
но не число, метка должна содержать информацию об этом.*/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Homework_5
{
    class MyClass: Form
    {
        TextBox firstNum, secondNum;
        Label measur;
        int num1 = 0;
        int num2 = 0;

        public MyClass(): base()
        {
            Size = new Size(400, 200);
            firstNum = new TextBox();
            firstNum.Location = new Point(10, 10);
            firstNum.KeyUp += ComparisonNumbers;
            Controls.Add(firstNum);

            measur = new Label();
            measur.SetBounds(firstNum.Right + 10, 10, 60, 19);
            measur.BorderStyle = BorderStyle.FixedSingle;
            measur.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(measur);

            secondNum = new TextBox();
            secondNum.Location = new Point(measur.Right + 10, 10);
            secondNum.KeyUp += ComparisonNumbers;
            Controls.Add(secondNum);
        }

        void ComparisonNumbers(object obj, EventArgs ea)
        {
            bool firstOk = int.TryParse(firstNum.Text, out int n1);
            bool secondOk = int.TryParse(secondNum.Text, out int n2);

            if (!firstOk || !secondOk)
            {
                measur.Text = "Не число!";
                return;
            }

            if (n1 > n2) measur.Text = ">";
            else if (n1 < n2) measur.Text = "<";
            else measur.Text = "=";
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
