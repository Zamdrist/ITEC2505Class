using System;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                this.customersTableAdapter.Fill(this.customerIncidentsDataSet.Customers);
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

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            this.FillCustomersByState();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.customersDataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show(
                    "No selection made. Search again and select a customer",
                    "Search By State");
                return;
            }
            this.UseSelectedCustomer();
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
            try
            {
                this.customersTableAdapter.Fill(this.customerIncidentsDataSet.Customers);
                this.stateToolStripTextBox.Text = string.Empty;
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

        private void FillCustomersByState()
        {
            try
            {
                this.customersTableAdapter.FillByState(
                    this.customerIncidentsDataSet.Customers,
                    this.stateToolStripTextBox.Text);
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

        private void UseSelectedCustomer()
        {
            this.Tag = this.customersDataGridView.SelectedCells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.UseSelectedCustomer();
        }
    }
}
