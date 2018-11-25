using System;

namespace CalculatorApp
{
    public class MemoryCalculator
    {
        public double StoredValue { get; set; }

        public double MemorySum(double value)
        {
            return value + this.StoredValue;
        }
    }
}
