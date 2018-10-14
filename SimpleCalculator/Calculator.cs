using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public class Calculator
    {
        private decimal _result;
        private readonly List<string> _validOperators = new List<string> { "+", "-", "*", "/" };

        private enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public decimal Result
        {
            get { return this._result; }
            private set { this._result = Math.Round(value, 4); }
        }

        private Operation ValidOperation(string operation)
        {
            //Use the index of list item and cast to the appropriate enum
            var operatorIndex = this._validOperators.IndexOf(operation);
            return (Operation) operatorIndex;
        }

        public void PerformCalculation(decimal operand1, string operatorString, decimal operand2)
        {
            var operation = this.ValidOperation(operatorString);
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (operation)
            {
                case Operation.Add:
                    this.Result = operand1 + operand2;
                    break;
                case Operation.Subtract:
                    this.Result = operand1 - operand2;
                    break;
                case Operation.Multiply:
                    this.Result = operand1 * operand2;
                    break;
                case Operation.Divide:
                    this.Result = operand1 / operand2;
                    break;
            }

        }

        public bool IsValidOperator(TextBox operatorString)
        {
            if (!this._validOperators.Any(o => o.Equals(operatorString.Text)))
            {
                MessageBox.Show($"{operatorString.Text} is not a valid operator", "Simple Calculator");
                operatorString.Text = string.Empty;
                operatorString.Focus();
                return false;
            }

            return true;
        }

        public bool IsDecimal(TextBox value, string name)
        {
            if (!decimal.TryParse(value.Text, out var theValue))
            {
                MessageBox.Show($"{name} is not a valid decimal value", "Simple Calculator");
                value.Text = string.Empty;
                value.Focus();
                return false;
            }
            else if (theValue == 0 || theValue >= 1000000)
            {
                MessageBox.Show($"Value must be greater than 0 and less than 1,000,000", "Simple Calculator");
                value.Text = string.Empty;
                value.Focus();
                return false;
            }
            return true;
        }

        public bool IsPresent(TextBox value, string name)
        {
            if (string.IsNullOrEmpty(value.Text))
            {
                MessageBox.Show($"{name} is required", "Simple Calculator");
                value.Focus();
                return false;
            }
            return true;
        }
    }
}
