/*Напишите программу, в которой отображается окно с главным меню
и областью с текстом. Текст содержит информацию о названии, стиле
и размере шрифта, которым отображается текст. В меню есть пункты для
выбора названия шрифта, стиля шрифта и размера шрифта. При выбо-
ре команды из меню соответствующая характеристика применяется для
отображения текста, а также с учетом новых параметров шрифта меня-
ется сам текст.*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Homework_9
{
    class MyClass: Form
    {
        Label contaner;
        MainMenu menu;
        string[] text = { };
        Font font = new Font("Arial", 12, FontStyle.Regular);

        string[] fontNames = { "Arial", "Times New Roman", "Courier New", "Verdana", "Calibri" };
        float[] fontSizes = { 12, 14, 16, 18, 20};
        FontStyle[] fontStyles = { FontStyle.Regular, FontStyle.Bold, FontStyle.Italic, FontStyle.Underline, FontStyle.Strikeout };

        public MyClass(): base()
        {
            Size = new Size(500, 500);

            menu = new MainMenu();
            Menu = menu;
            MenuItem name = new MenuItem("Название шрифта");
            MenuItem size = new MenuItem("Размер шрифта");
            MenuItem style = new MenuItem("Стиль шрифта");

            menu.MenuItems.Add(name);
            menu.MenuItems.Add(size);
            menu.MenuItems.Add(style);

            for (int i = 0; i < fontNames.Length; i++)
            {
                int index = i;

                MenuItem item = new MenuItem(fontNames[index].ToString());
                item.Click += (obj, ea) =>
                {
                    font = new Font(fontNames[index], font.Size, font.Style);
                    contaner.Font = font;
                    text[0] = fontNames[index];
                    contaner.Text = String.Join(" ", text);
                };
                name.MenuItems.Add(item);
            }

            for (int i = 0; i < fontSizes.Length; i++)
            {
                int index = i;

                MenuItem item = new MenuItem(fontSizes[index].ToString());
                item.Click += (obj, ea) =>
                {
                    font = new Font(font.FontFamily, fontSizes[index], font.Style);
                    contaner.Font = font;
                    text[1] = Convert.ToString(fontSizes[index]);
                    contaner.Text = String.Join(" ", text);
                };
                size.MenuItems.Add(item);
            }

            for (int i = 0; i < fontStyles.Length; i++)
            {
                int index = i;

                MenuItem item = new MenuItem(fontStyles[index].ToString());
                item.Click += (obj, ea) =>
                {
                    font = new Font(font.FontFamily, font.Size, fontStyles[index]);
                    contaner.Font = font;
                    text[2] = Convert.ToString(fontStyles[index]);
                    contaner.Text = String.Join(" ", text);
                };
                style.MenuItems.Add(item);
            }

            text = new string[]{ fontNames[0], Convert.ToString(fontSizes[0]), Convert.ToString(fontStyles[0])};

            contaner = new Label();
            contaner.Text = String.Join(" ", text);
            contaner.SetBounds(10, 10, 150, 150);
            contaner.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(contaner);
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
