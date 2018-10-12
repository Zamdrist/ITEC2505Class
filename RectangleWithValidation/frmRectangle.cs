using System;
using System.Windows.Forms;

namespace RectangleWithValidation
{
    public partial class FormRectangle : Form
    {
        public FormRectangle()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle();

            if (this.IsValid(rectangle))
            {
                var length = Convert.ToDecimal(this.txtLength.Text);
                var width = Convert.ToDecimal(this.txtWidth.Text);

                rectangle.RectangleDimensions(length, width);
                this.lblAreaValue.Text = rectangle.Area.ToString();
                this.lblPerimeterValue.Text = rectangle.Perimeter.ToString();
                this.btnCalc.Focus();
            }

        }

        private bool IsValid(Rectangle rectangle)
        {
            return rectangle.IsPresent(this.txtLength, this.lblLength.Text)
                && rectangle.IsDecimal(this.txtLength, this.lblLength.Text)
                && rectangle.IsPresent(this.txtWidth, this.lblWidth.Text)
                && rectangle.IsDecimal(this.txtWidth, this.lblWidth.Text);
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            this.lblAreaValue.Text = string.Empty;
            this.lblPerimeterValue.Text = string.Empty;
        }
    }
}
