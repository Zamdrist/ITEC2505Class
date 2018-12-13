using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class ProductMaintenanceForm : Form
    {
        public ProductMaintenanceForm()
        {
            this.InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);

        }

        private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
	        var row = e.RowIndex + 1;
	        var errorMessage =
		        $"A data error occurred.{Environment.NewLine}Row: {row}{Environment.NewLine}Error: {e.Exception.Message}";
	        MessageBox.Show(errorMessage);
        }
    }
}
