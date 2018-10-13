
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Calculator
    {
        private List<string> _validOperators = new List<string> {"+", "-", "*", "/"};

	    public decimal Operand1 { get; set; }
	    public decimal Operand2 { get; set; }
	    public decimal Result { get; set; }
	    public string Operator { get; set; }

	    public bool IsValidOperator(string operatorString)
	    {
		    return this._validOperators.Any(o => o.Equals(operatorString));
	    }


    }
}
