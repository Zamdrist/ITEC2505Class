using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FormSimpleCalculator : Form
    {
        public FormSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
			var calculator = new Calculator();
	        MessageBox.Show(calculator.IsValidOperator(this.txtOperator.Text).ToString());
        }
    }
}
