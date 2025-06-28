/*Напишите программу, в которой отображается окно, представляю-
щее собой арифметический калькулятор.*/

using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_I0
{
    class Calculator: Form
    {
        TextBox expression;
        Button zero, one, two, three, four, five, six, seven, eight, nine;
        Button plus, minus, multiply, divide, equal, delete;

        public Calculator(): base()
        {
            ClientSize = new Size(450, 300);
            Font fontNums = new Font(Font.FontFamily, 15, FontStyle.Regular);

            expression = new TextBox();
            expression.Location = new Point(10, 10);
            expression.Width = ClientSize.Width - 20;
            expression.Font = fontNums;
            expression.KeyDown += Expression_KeyDown;
            Controls.Add(expression);

            seven = new Button();
            seven.Text = "7";
            seven.Font = fontNums;
            seven.Click += ClickOnButton;
            seven.SetBounds(10, expression.Bottom + 10, 100, 50);

            eight = new Button();
            eight.Text = "8";
            eight.Font = fontNums;
            eight.Click += ClickOnButton;
            eight.SetBounds(seven.Right + 10, expression.Bottom + 10, 100, 50);

            nine = new Button();
            nine.Text = "9";
            nine.Font = fontNums;
            nine.Click += ClickOnButton;
            nine.SetBounds(eight.Right + 10, expression.Bottom + 10, 100, 50);

            divide = new Button();
            divide.Text = "÷";
            divide.Font = fontNums;
            divide.Click += ClickOnButton;
            divide.SetBounds(nine.Right + 10, expression.Bottom + 10, 100, 50);

            four = new Button();
            four.Text = "4";
            four.Font = fontNums;
            four.Click += ClickOnButton;
            four.SetBounds(seven.Left, seven.Bottom + 10, 100, 50);

            five = new Button();
            five.Text = "5";
            five.Font = fontNums;
            five.Click += ClickOnButton;
            five.SetBounds(four.Right + 10, seven.Bottom + 10, 100, 50);

            six = new Button();
            six.Text = "6";
            six.Font = fontNums;
            six.Click += ClickOnButton;
            six.SetBounds(five.Right + 10, seven.Bottom + 10, 100, 50);

            multiply = new Button();
            multiply.Text = "×";
            multiply.Font = fontNums;
            multiply.Click += ClickOnButton;
            multiply.SetBounds(six.Right + 10, seven.Bottom + 10, 100, 50);

            one = new Button();
            one.Text = "1";
            one.Font = fontNums;
            one.Click += ClickOnButton;
            one.SetBounds(seven.Left, four.Bottom + 10, 100, 50);

            two = new Button();
            two.Text = "2";
            two.Font = fontNums;
            two.Click += ClickOnButton;
            two.SetBounds(one.Right + 10, four.Bottom + 10, 100, 50);

            three = new Button();
            three.Text = "3";
            three.Font = fontNums;
            three.Click += ClickOnButton;
            three.SetBounds(two.Right + 10, four.Bottom + 10, 100, 50);

            minus = new Button();
            minus.Text = "-";
            minus.Font = fontNums;
            minus.Click += ClickOnButton;
            minus.SetBounds(three.Right + 10, four.Bottom + 10, 100, 50);

            delete = new Button();
            delete.Text = "Delete";
            delete.Font = fontNums;
            delete.Click += ClickOnButton;
            delete.SetBounds(seven.Left, one.Bottom + 10, 100, 50);

            zero = new Button();
            zero.Text = "0";
            zero.Font = fontNums;
            zero.Click += ClickOnButton;
            zero.SetBounds(delete.Right + 10, one.Bottom + 10, 100, 50);

            equal = new Button();
            equal.Text = "=";
            equal.Font = fontNums;
            equal.Click += ClickOnButton;
            equal.SetBounds(zero.Right + 10, one.Bottom + 10, 100, 50);

            plus = new Button();
            plus.Text = "+";
            plus.Font = fontNums;
            plus.Click += ClickOnButton;
            plus.SetBounds(equal.Right + 10, one.Bottom + 10, 100, 50);

            Controls.Add(zero);
            Controls.Add(one);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(nine);

            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(equal);
            Controls.Add(delete);
        }

        private async void Expression_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string text = expression.Text.Replace(',', '.');
                    expression.Text = Convert.ToString(new DataTable().Compute(text, null));
                }
                catch
                {
                    expression.Text = "Ошибка!";
                    await Task.Delay(1500);
                    expression.Text = "";
                }
            }
        }
        
        async void ClickOnButton(object obj, EventArgs ea)
        {
            Button btn = (Button)obj;

            try
            {
                switch (btn.Text)
                {
                    case "0":
                        expression.Text += "0";
                        break;
                    case "1":
                        expression.Text += "1";
                        break;
                    case "2":
                        expression.Text += "2";
                        break;
                    case "3":
                        expression.Text += "3";
                        break;
                    case "4":
                        expression.Text += "4";
                        break;
                    case "5":
                        expression.Text += "5";
                        break;
                    case "6":
                        expression.Text += "6";
                        break;
                    case "7":
                        expression.Text += "7";
                        break;
                    case "8":
                        expression.Text += "8";
                        break;
                    case "9":
                        expression.Text += "9";
                        break;
                    case "÷":
                        expression.Text += "/";
                        break;
                    case "×":
                        expression.Text += "*";
                        break;
                    case "-":
                        expression.Text += "-";
                        break;
                    case "+":
                        expression.Text += "+";
                        break;
                    case "=":
                        string text = expression.Text.Replace(',', '.');
                        expression.Text = Convert.ToString(new DataTable().Compute(text, null));
                        break;
                    case "Delete":
                        expression.Text = "";
                        break;
                }
            }
            catch
            {
                expression.Text = "Ошибка!";
                await Task.Delay(1500);
                expression.Text = "";
            }
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Calculator());
        }
    }
}
