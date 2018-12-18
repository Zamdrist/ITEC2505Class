using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerIncidentsApp
{
    public partial class CustomerIncidentsForm : Form
    {
        private Form _formAddNewIncident;
        private Form _formSearchByState;

        public CustomerIncidentsForm()
        {
            this.InitializeComponent();
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            if (Validation.IsPresent(this.customerIdToolStripTextBox.Text, "Customer ID"))
            {
                this.FillByCustomerId();
            }
        }

        private void btnAddNewIncident_Click(object sender, EventArgs e)
        {
            if (Validation.IsPresent(this.customerIDTextBox.Text, "Customer ID"))
            {
                this._formAddNewIncident = new AddIncidentForm();
                var idNamePair = new[] {this.customerIDTextBox.Text, this.nameTextBox.Text};
                this._formAddNewIncident.Tag = idNamePair;
                var result = this._formAddNewIncident.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    this.FillByCustomerId();
                }
                this._formAddNewIncident.Dispose();
            }
        }

        private void tsBtnSearchByState_Click(object sender, EventArgs e)
        {
            this._formSearchByState = new FindCustomerForm();
            var result = this._formSearchByState.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.customerIdToolStripTextBox.Text = this._formSearchByState.Tag.ToString();
                this.FillByCustomerId();
            }
            this._formSearchByState.Dispose();
        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            this.ClearSearch();
        }

	    private void ClearSearch()
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
	            var isNumeric = int.TryParse(this.customerIdToolStripTextBox.Text, out var i);

	            if (!isNumeric)
	            {
		            this.ClearSearch();
					return;
                }

	            this.customersTableAdapter.FillBy(
		            this.customerIncidentsDataSet.Customers,
		            ((int)(Convert.ChangeType(
			            i,
			            typeof(int)))));
	            this.incidentsTableAdapter.Fill(this.customerIncidentsDataSet.Incidents);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show(
                    "A concurrency error occurred. Some rows were not updated",
                    "Concurrency Exception");
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Database error # {ex.Number}: {ex.Message}",
                    ex.GetType().ToString());
            }
        }

        private void CustomerIncidentsForm_Load(object sender, EventArgs e)
        {
        }
    }
}
