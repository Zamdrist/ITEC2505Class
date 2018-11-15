﻿using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
	    private readonly Calculator _calculator = new Calculator();

        public CalculatorForm()
        {
            this.InitializeComponent();
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
	        //this.lblAnswer.Text = this.calculator.Operand.ToString();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
	        this.btn0.Click += this.AssignOperand;
            this.btn1.Click += this.AssignOperand;
	        this.btn2.Click += this.AssignOperand;
	        this.btn3.Click += this.AssignOperand;
	        this.btn4.Click += this.AssignOperand;
	        this.btn5.Click += this.AssignOperand;
	        this.btn6.Click += this.AssignOperand;
	        this.btn7.Click += this.AssignOperand;
	        this.btn8.Click += this.AssignOperand;
	        this.btn9.Click += this.AssignOperand;

	        this.btnDivide.Click += this.AssignOperator;
	        this.btnMultiply.Click += this.AssignOperator;
	        this.btnSubtract.Click += this.AssignOperator;
	        this.btnAdd.Click += this.AssignOperator;

	        this.btnSqrt.Click += this.AssignSpecialOperator;
	        this.btnReciprocal.Click += this.AssignSpecialOperator;
        }

	    private void AssignOperand(object sender, EventArgs e)
	    {
		    var button = (Button) sender;
		    this.lblAnswer.Text += button.Tag.ToString();
	    }

	    private void AssignOperator(object sender, EventArgs e)
	    {
		    var button = (Button) sender;
		    this._calculator.Operator = button.Tag.ToString();
		    this._calculator.Operand = Convert.ToDouble(this.lblAnswer.Text);
		    this.lblPlaceHolder.Text = $"{this._calculator.Operand} {this._calculator.Operator}";
		    this.lblAnswer.Text = string.Empty;

	    }

	    private void AssignSpecialOperator(object sender, EventArgs e)
	    {
		    if (!string.IsNullOrEmpty(this.lblAnswer.Text))
		    {
			    var button = (Button)sender;
			    this._calculator.Operator = button.Tag.ToString();
			    this._calculator.Operand = Convert.ToDouble(this.lblAnswer.Text);
			    this._calculator.CalculateResult();
			    this.lblAnswer.Text = this._calculator.Result.ToString();
            }
	    }

        private void btnEquals_Click(object sender, EventArgs e)
        {
	        if (!string.IsNullOrEmpty(this.lblAnswer.Text)
		        && !string.IsNullOrEmpty(this._calculator.Operator))
	        {
		        this._calculator.CalculateResult(Convert.ToDouble(this.lblAnswer.Text));
		        this.lblAnswer.Text = this._calculator.Result.ToString();
		        this.lblPlaceHolder.Text = string.Empty;
	        }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
	        this.lblAnswer.Text = string.Empty;
	        this.lblPlaceHolder.Text = string.Empty;
			this._calculator.ClearAll();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
	        var button = (Button) sender;
	        this._calculator.Operand = Convert.ToDouble(this.lblAnswer.Text);
	        this._calculator.Operator = button.Tag.ToString();
			this._calculator.CalculateResult();
	        this.lblAnswer.Text = this._calculator.Result.ToString();
        }
    }
}
