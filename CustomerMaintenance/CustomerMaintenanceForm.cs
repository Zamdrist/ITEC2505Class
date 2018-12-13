using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class CustomerMaintenanceForm : Form
    {
        public CustomerMaintenanceForm()
        {
            this.InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
	        try
	        {
		        this.Validate();
		        this.customersBindingSource.EndEdit();
		        this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
	        }
	        catch (DBConcurrencyException)
	        {
		        MessageBox.Show(
			        "A concurrency error occurred. Some rows were not updated",
			        "Concurrency Exception");
		        this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);
	        }
	        catch (DataException ex)
	        {
		        MessageBox.Show(ex.Message, ex.GetType().ToString());
				this.customersBindingSource.CancelEdit();
	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(
			        $"Database error # {ex.Number}: {ex.Message}",
			        ex.GetType().ToString());
	        }


        }

        private void CustomerMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

        }
    }
}
