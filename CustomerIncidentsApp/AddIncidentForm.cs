using System;
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
			MessageBox.Show(this.cmbProducts.SelectedValue.ToString());
		}

		private void AddIncidentForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'customerIncidentsDataSet1.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.customerIncidentsDataSet1.Products);

			this.productsTableAdapter.Fill(this.customerIncidentsDataSet.Products);
			if (this.Tag != null)
			{
				var idNamePair = (string[]) this.Tag;
				this.lblCustomerIdValue.Text = idNamePair[0];
				this.lblNameValue.Text = idNamePair[1];
			}

			this.cmbProducts.ResetText();
			this.cmbProducts.SelectedIndex = -1;
		}
	}
}
