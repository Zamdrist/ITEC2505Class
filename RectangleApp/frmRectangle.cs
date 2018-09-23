using System;
using System.Windows.Forms;

namespace RectangleApp
{
    public partial class FrmRectangle : Form
    {
        public FrmRectangle()
        {
            this.InitializeComponent();
        }

		private void btnCalc_Click(object sender, EventArgs e)
		{
            decimal.TryParse(this.txtLength.Text, out var length);
            decimal.TryParse(this.txtWidth.Text, out var width);

			var rectangle = new Rectangle(length, width);

			this.lblArea.Text = rectangle.Area.ToString();
			this.lblPerimeter.Text = rectangle.Perimeter.ToString();

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			const string zeroString = "0";
			this.txtLength.Text = zeroString;
			this.txtWidth.Text = zeroString;
			this.lblArea.Text = zeroString;
			this.lblPerimeter.Text = zeroString;
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
