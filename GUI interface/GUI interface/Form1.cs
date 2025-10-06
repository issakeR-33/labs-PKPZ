using System;
using System.Windows.Forms;

namespace GUI_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TextBox inputTextBox = new TextBox()
            {
                Left = 20,
                Top = 20,
                Width = 200
            };

            Button processButton = new Button()
            {
                Left = 230,
                Top = 18,
                Text = "Start"
            };

            Label resultLabel = new Label()
            {
                Left = 20,
                Top = 60,
                Width = 400
            };

            
            this.Controls.Add(inputTextBox);
            this.Controls.Add(processButton);
            this.Controls.Add(resultLabel);

            // Обробка натискання кнопки
            processButton.Click += (sender, e) =>
            {
                string input = inputTextBox.Text;
                char[] chars = input.ToCharArray();
                int digitCount = 0;

                for (int i = 0; i < chars.Length; i++)
                {
                    if (Char.IsDigit(chars[i]))
                    {
                        digitCount++;
                        chars[i] = '!';
                    }
                }

                string result = new string(chars);
                resultLabel.Text = $"Number of digits: {digitCount}, Resilt: {result}";
            };
        }
    }
}
