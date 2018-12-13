using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductMaintenanceApp
{
    public partial class ProductMaintenanceForm : Form
    {
        public ProductMaintenanceForm()
        {
            this.InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
	        try
	        {
		        this.Validate();
		        this.productsBindingSource.EndEdit();
		        this.tableAdapterManager.UpdateAll(this.productsDataSet);
		        this.productCodeTextBox.Enabled = false;
	        }
	        catch (DBConcurrencyException)
	        {
		        MessageBox.Show(
			        "A concurrency error occurred. Some rows were not updated",
			        "Concurrency Exception");
		        this.productsTableAdapter.Fill(this.productsDataSet.Products);
	        }
	        catch (DataException ex)
	        {
		        MessageBox.Show(ex.Message, ex.GetType().ToString());
		        //this.productsBindingSource.CancelEdit();
	        }

	        catch (SqlException ex)
	        {
		        MessageBox.Show(
			        $"Database error # {ex.Number}: {ex.Message}",
			        ex.GetType().ToString());
	        }

        }

        private void ProductMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
        }

        private void fillByProductCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByProductCode(this.productsDataSet.Products, this.productCodeToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
	        this.productCodeTextBox.Enabled = true;
			this.releaseDateDateTimePicker.Value = DateTime.Now;
	        this.productCodeTextBox.Focus();
        }
    }
}
