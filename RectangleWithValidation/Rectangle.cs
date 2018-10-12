using System;
using System.Windows.Forms;

namespace RectangleWithValidation
{
    public class Rectangle
    {
        public decimal Area { get; private set; }
        public decimal Perimeter { get; private set; }

        public bool IsPresent(TextBox textbox, string name)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                MessageBox.Show($"{name} is a required field", $"{name} Required");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textbox, string name)
        {
            if (!decimal.TryParse(textbox.Text, out var value))
            {
                MessageBox.Show($"{textbox.Text} is not a valid decimal value", $"{name} Required");
                textbox.Text = string.Empty;
                textbox.Focus();
                return false;
            }
            else if (value == 0)
            {
                MessageBox.Show($"{name} must be greater than zero", $"{name} Required");
                textbox.Text = string.Empty;
                textbox.Focus();
                return false;
            }
            return true;
        }


        public void RectangleDimensions(decimal length, decimal width)
        {
            this.Area = Math.Round(length * width, 2);
            this.Perimeter = Math.Round(2 * (length + width), 2);

        }

    }
}
