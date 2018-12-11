using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaintainTechniciansApp
{
    public partial class MaintainTechniciansForm : Form
    {
        public MaintainTechniciansForm()
        {
            this.InitializeComponent();
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
	        try
	        {
		        this.Validate();
		        this.techniciansBindingSource.EndEdit();
		        this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
	        }
            catch (DBConcurrencyException)
	        {
		        MessageBox.Show(
			        "A concurrency error occurred. Some rows were not updated",
			        "Concurrency Exception");
		        this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);
	        }
	        catch (DataException ex)
	        {
		        MessageBox.Show(ex.Message, ex.GetType().ToString());
		        this.techniciansBindingSource.CancelEdit();
	        }

	        catch (SqlException ex)
	        {
		        MessageBox.Show(
			        $"Database error # {ex.Number}: {ex.Message}",
			        ex.GetType().ToString());
	        }


        }

	    private void MaintainTechniciansForm_Load(object sender, EventArgs e)
	    {
		    this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);

		    var techsuppDataGridColumns = this.techniciansDataGridView.Columns;
		    foreach (DataGridViewColumn techsuppDataGridColumn in techsuppDataGridColumns)
		    {
			    if (techsuppDataGridColumn.Visible)
			    {
				    techsuppDataGridColumn.Width = this.techniciansDataGridView.Width / 3;
			    }
		    }
	    }

	    private void techniciansDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
	        var row = e.RowIndex + 1;
	        var errorMessage =
		        $"A data error occurred.{Environment.NewLine}Row: {row}{Environment.NewLine}Error: {e.Exception.Message}";
	        MessageBox.Show(errorMessage,"Data error");
        }
    }
}
