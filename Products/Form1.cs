using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmProductCalculator : Form
    {
	    private const decimal tax = 0.055m;
		List<string[]> _products = new List<string[]>();

        public frmProductCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
			if (this.IsPresent(this.txtProduct.Text)
		        && this.isValidValue(this.txtPrice.Text)
		        && this.isValidValue(this.txtQuantity.Text))
	        {
		        var price = Convert.ToDecimal(this.txtPrice.Text);
		        var quantity = Convert.ToDecimal(this.txtQuantity.Text);
		        var preTaxTotal = price * quantity;
		        var taxedAmount = preTaxTotal * frmProductCalculator.tax;
		        var grandTotal = preTaxTotal + taxedAmount;

		        var productName = new string[1];
		        productName[0] = this.txtProduct.Text;

		        var values = new string[3];
		        values[0] = price.ToString();
		        values[1] = quantity.ToString();
		        values[2] = grandTotal.ToString();

				this._products.Add(values);

		        var returnText = "Product: " + productName[0] + Environment.NewLine;
		        var prices = string.Empty;

			    prices += "Price: " + values[0] + Environment.NewLine;
		        prices += "Quantity: " + values[1] + Environment.NewLine;
		        prices += "Grand Total: " + values[2] + Environment.NewLine;

                MessageBox.Show(returnText + prices);
	        }
        }

	    private bool IsPresent(string value)
	    {

		    if (string.IsNullOrEmpty(value))
		    {
			    MessageBox.Show("You must enter a product name!");
			    return false;
		    }

		    return true;
	    }
	    private bool isValidValue(string value)
	    {
		    if (!decimal.TryParse(value, out var theValue))
		    {
			    MessageBox.Show("Please enter a valid quantity and price!");
			    return false;
		    }
		    return true;


	    }

	    private bool HasProduct(string product)
	    {
		    if (string.IsNullOrEmpty(product))
		    {
			    MessageBox.Show("You must specify a product");
			    return false;

		    }
		    return true;
	    }
    }
}
