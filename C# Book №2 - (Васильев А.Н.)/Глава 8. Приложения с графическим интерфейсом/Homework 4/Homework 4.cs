/*Напишите программу, в которой открывается окно с полем ввода. При
вводе текста в окно этот текст автоматически дублируется в текстовой
метке. В окне должны быть две опции, которые позволяют применять
к тексту в метке жирный и курсивный стили.*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Homework_4
{
    class MyClass: Form
    {
        Label discription;
        TextBox txt;
        Button btn;
        Label lbl;
        List<string> lblList = new List<string>();
        CheckBox optionBold;
        CheckBox optionItalic;
        Button delWord;
        Button delAllWords;

        Font font = new Font("Times new Roman", 14, FontStyle.Regular);
        FontStyle bold = FontStyle.Bold;
        FontStyle italic = FontStyle.Italic;
        FontStyle boldItalic = FontStyle.Italic | FontStyle.Bold;
        FontStyle regular = FontStyle.Regular;

        public MyClass(): base()
        {
            AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            discription = new Label();
            discription.AutoSize = true;
            discription.Text = "Введите текст!";
            discription.Location = new Point(10, 10);
            discription.Font = font;
            Controls.Add(discription);

            txt = new TextBox();
            txt.Location = new Point(10, discription.Bottom + 10);
            txt.Width = Size.Width - 50;
            txt.Multiline = true;
            txt.Height = 50;
            Controls.Add(txt);

            btn = new Button();
            btn.Location = new Point(txt.Right + 10, discription.Bottom + 10);
            btn.Height = 50;
            btn.Text = "Ввод";
            btn.Font = font;
            btn.Click += ClickButton;
            Controls.Add(btn);

            lbl = new Label();
            lbl.SetBounds(10, txt.Bottom + 10, Size.Width - 25, 100);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.BackColor = Color.White;
            Controls.Add(lbl);

            optionBold = new CheckBox();
            optionBold.Font = font;
            optionBold.AutoSize = true;
            optionBold.Text = "Жирный шрифт";
            optionBold.Location = new Point(10, lbl.Bottom + 10);
            optionBold.CheckedChanged += SetOption;
            Controls.Add(optionBold);

            optionItalic = new CheckBox();
            optionItalic.Font = font;
            optionItalic.AutoSize = true;
            optionItalic.Text = "Курсивный шрифт";
            optionItalic.Location = new Point(optionBold.Right + 10, lbl.Bottom + 10);
            optionItalic.CheckedChanged += SetOption;
            Controls.Add(optionItalic);

            delWord = new Button();
            delWord.Text = "Убрать";
            delWord.Font = font;
            delWord.SetBounds(10, optionBold.Bottom + 10, ClientSize.Width / 2 - 15, 30);
            delWord.Click += ClickButton;
            Controls.Add((delWord));

            delAllWords = new Button();
            delAllWords.Text = "Убрать всё";
            delAllWords.Font = font;
            delAllWords.SetBounds(delWord.Right + 10, optionBold.Bottom + 10, ClientSize.Width / 2 - 15, 30);
            delAllWords.Click += ClickButton;
            Controls.Add((delAllWords));
        }

        private void ClickButton(object obj, EventArgs ea)
        {
            Button button = (Button)obj;
            if(button.Text == "Ввод")
            {
                if(txt.Text != null && txt.Text != "")
                {
                    lblList.Add(txt.Text + " ");
                    lbl.Text = String.Concat<string>(lblList);
                    txt.Text = "";
                }
            }

            else if (button.Text == "Убрать")
            {
                if (lblList != null && lblList.Count > 0)
                {
                    lblList.RemoveAt(lblList.Count - 1);
                    lbl.Text = String.Concat<string>(lblList);
                }
            }

            else if (button.Text == "Убрать всё")
            {
                if (lblList != null && lblList.Count > 0)
                {
                    lblList.Clear();
                    lbl.Text = "";
                }
            }
        }

        private void SetOption(object obj, EventArgs ea)
        {
            if (optionBold.Checked == true && optionItalic.Checked == false)
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size, bold);
            else if (optionBold.Checked == false && optionItalic.Checked == true)
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size, italic);
            else if (optionBold.Checked == true && optionItalic.Checked == true)
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size, boldItalic);
            else if (optionBold.Checked == false && optionItalic.Checked == false)
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size, regular);
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
