using System;
using System.Windows.Forms;

namespace Factorials
{
	public partial class Factorials : Form
	{
		public Factorials()
		{
			InitializeComponent();
		}

		private double CalculateFactorial(double factorial)
		{
			// ReSharper disable once CompareOfFloatsByEqualityOperator
			if (factorial == 1)
			{
				return 1;
			}
			else
			{
				return factorial * this.CalculateFactorial(factorial - 1);
			}
		}

		private void CallCf()
		{
			var returns = this.CalculateFactorial((double)this.udNumber.Value);
			this.lblFactorials.Text = returns.ToString("N0");
        }

        private void udNumber_ValueChanged(object sender, EventArgs e)
        {
	        this.CallCf();

        }

        private void Factorials_Load(object sender, EventArgs e)
        {
			this.CallCf();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
