using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FormSimpleCalculator : Form
    {
        public FormSimpleCalculator()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new Calculator();

                if (this.IsValidData(calculator))
                {
                    var operand1 = Convert.ToDecimal(this.txtOperand1.Text);
                    var operand2 = Convert.ToDecimal(this.txtOperand2.Text);
                    calculator.PerformCalculation(operand1, this.txtOperator.Text, operand2);
                    this.lblResultValue.Text = calculator.Result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"{ex.Message}{Environment.NewLine}{Environment.NewLine}"
                    + $"{ex.GetType()}{Environment.NewLine}{ex.StackTrace}",
                    "Exception");
            }

        }

        private bool IsValidData(Calculator calc)
        {
            return calc.IsPresent(this.txtOperand1, "Operand 1")
                && calc.IsDecimal(this.txtOperand1, "Operand 1")
                && calc.IsPresent(this.txtOperator, "Operator")
                && calc.IsValidOperator(this.txtOperator)
                && calc.IsPresent(this.txtOperand2, "Operand 2")
                && calc.IsDecimal(this.txtOperand2, "Operand 2");
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            this.lblResultValue.Text = string.Empty;
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            this.lblResultValue.Text = string.Empty;
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            this.lblResultValue.Text = string.Empty;
        }
    }
}
