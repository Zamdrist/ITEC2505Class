using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class Calculator
    {
	    private readonly List<string> _validOperators = new List<string>
		    {"+", "-", "*", "/", "Sqrt", "Reciprocal", "Sign"};

	    private enum Operation
	    {
		    Add,
		    Subtract,
		    Multiply,
		    Divide,
			Sqrt,
			Reciprocal,
			Sign
	    }

	    public double Operand { get; set; }
		public string Operator { get; set; }
		public double Result { get; private set; }

	    private Operation ValidOperation(string operation)
	    {
		    //Use the index of list item and cast to the appropriate enum
		    var operatorIndex = this._validOperators.IndexOf(operation);
		    return (Operation)operatorIndex;
	    }

	    public void ClearAll()
	    {
		    this.Result = default(double);
		    this.Operand = default(double);
		    this.Operator = default(string);
	    }

        public void CalculateResult(double secondOperand = default(double))
	    {
		    // ReSharper disable once SwitchStatementMissingSomeCases
		    switch (this.ValidOperation(this.Operator))
		    {
			    case Operation.Add:
				    this.Result = this.Operand + secondOperand;
				    break;
			    case Operation.Subtract:
				    this.Result = this.Operand - secondOperand;
				    break;
			    case Operation.Multiply:
				    this.Result = this.Operand * secondOperand;
				    break;
			    case Operation.Divide:
				    this.Result = this.Operand / secondOperand;
				    break;
                case Operation.Sqrt:
	                this.Result = Math.Sqrt(this.Operand);
					break;
                case Operation.Reciprocal:
	                this.Result = 1 / this.Operand;
					break;
                case Operation.Sign:
	                this.Result = this.Operand * -1;
					break;
		    }
	    }
    }


}
