using System;
using System.Windows.Forms;

namespace CustomerIncidentsApp
{
    public partial class FindCustomerForm : Form
    {
        public FindCustomerForm()
        {
            this.InitializeComponent();
        }

        private void FindCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerIncidentsDataSet.Incidents' table. You can move, or remove it, as needed.
            //this.incidentsTableAdapter.Fill(this.customerIncidentsDataSet.Incidents);
            // TODO: This line of code loads data into the 'customerIncidentsDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerIncidentsDataSet.Customers);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
	        this.FillCustomersByState();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
	        this.FillCustomers();
        }

	    private void stateToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
	    {
		    if (e.KeyCode == Keys.Enter)
		    {
			    this.FillCustomersByState();

		    }
	    }

	    private void FillCustomers()
	    {
		    this.customersTableAdapter.Fill(this.customerIncidentsDataSet.Customers);
		    this.stateToolStripTextBox.Text = string.Empty;
	    }

	    private void FillCustomersByState()
	    {
		    try
		    {
			    this.customersTableAdapter.FillBy1(
				    this.customerIncidentsDataSet.Customers,
				    this.stateToolStripTextBox.Text);
            }
		    catch (Exception ex)
		    {
			    MessageBox.Show(ex.Message);
		    }
        }
    }
}
