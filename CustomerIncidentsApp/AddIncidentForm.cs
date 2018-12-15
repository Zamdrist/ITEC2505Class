using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerIncidentsApp
{
    public partial class AddIncidentForm : Form
    {

        public AddIncidentForm()
        {
            this.InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.IsValidIncident(
                this.lblCustomerIdValue.Text,
                this.lblNameValue.Text,
                this.cmbProducts,
                this.txtTitle.Text,
                this.txtDescription.Text))
            {
                using (var incidentsTableAdapter =
                    new CustomerIncidentsDataSetTableAdapters.IncidentsTableAdapter())
                {
                    try
                    {
                        incidentsTableAdapter.Insert(
                            Convert.ToInt32(this.lblCustomerIdValue.Text),
                            this.cmbProducts.SelectedValue.ToString(),
                            Convert.ToDateTime($"{DateTime.Now:d}"),
                            null,
                            this.txtTitle.Text,
                            this.txtDescription.Text);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
            }
        }

        private void AddIncidentForm_Load(object sender, EventArgs e)
        {

            this.productsTableAdapter.Fill(this.customerIncidentsDataSet.Products);
            if (this.Tag != null)
            {
                var idNamePair = (string[]) this.Tag;
                this.lblCustomerIdValue.Text = idNamePair[0];
                this.lblNameValue.Text = idNamePair[1];
                this.Tag = null;
            }

            this.cmbProducts.ResetText();
            this.cmbProducts.SelectedIndex = -1;
        }

        private bool IsValidIncident(
            string customerId,
            string customerName,
            ComboBox product,
            string title,
            string description)
        {
            var isValid = Validation.IsPresent(customerId, "Customer ID")
                && Validation.IsPresent(customerName, "Customer Name")
                && Validation.IsSelected(product, "Product")
                && Validation.IsPresent(title, "Title")
                && Validation.IsPresent(description, "Description");
            return isValid;
        }
    }
}
