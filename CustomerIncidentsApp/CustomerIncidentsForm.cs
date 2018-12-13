using System;
using System.Windows.Forms;

namespace CustomerIncidentsApp
{
    public partial class CustomerIncidentsForm : Form
    {
		private readonly Form _formAddNewIncident = new AddIncidentForm();
		private readonly Form _formSearchByState = new FindCustomerForm();

        public CustomerIncidentsForm()
        {
            this.InitializeComponent();
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            this.FillByCustomerId();

        }

        private void btnAddNewIncident_Click(object sender, EventArgs e)
        {
	        if (!string.IsNullOrEmpty(this.customerIDTextBox.Text))
	        {
		        var idNamePair = new[] {this.customerIDTextBox.Text, this.nameTextBox.Text};
		        this._formAddNewIncident.Tag = idNamePair;
		        this._formAddNewIncident.ShowDialog(this);
            }
        }

        private void tsBtnSearchByState_Click(object sender, EventArgs e)
        {
	        this._formSearchByState.ShowDialog();
        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
	        this.customerIncidentsDataSet.Clear();
	        this.customerIdToolStripTextBox.Text = string.Empty;
        }

        private void customerIdToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
	        if (e.KeyCode == Keys.Enter)
	        {
		        this.FillByCustomerId();
	        }
        }

	    private void FillByCustomerId()
	    {
		    try
		    {
			    this.customersTableAdapter.FillBy(this.customerIncidentsDataSet.Customers, ((int)(System.Convert.ChangeType(customerIdToolStripTextBox.Text, typeof(int)))));
			    this.incidentsTableAdapter.Fill(this.customerIncidentsDataSet.Incidents);
            }
		    catch (Exception ex)
		    {
			    MessageBox.Show(ex.Message);
		    }
        }

	    private void CustomerIncidentsForm_Load(object sender, EventArgs e)
	    {
	    }
    }
}
