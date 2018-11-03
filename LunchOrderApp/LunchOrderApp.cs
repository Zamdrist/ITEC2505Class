using System;
using System.Linq;
using System.Windows.Forms;

namespace LunchOrderApp
{
	public partial class LunchOrderApp : Form
	{
		private readonly Lunch _lunch = new Lunch();

		public LunchOrderApp()
		{
			this.InitializeComponent();

		}

		private void LunchOrderApp_Load(object sender, EventArgs e)
		{
			this.dgAddOns.AutoGenerateColumns = false;
			this.dgOrderSummary.AutoGenerateColumns = false;
			this.dgMainCourse.AutoGenerateColumns = false;
			this.dgMainCourse.DataSource = this._lunch.MainCourse;
			this.dgMainCourse.ClearSelection();
		}

		private void dgMainCourse_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dgMainCourse.Focused)
			{
				if (this.dgMainCourse.SelectedRows.Count != 0)
				{
					var mainCourseItem = this.dgMainCourse
						.Rows[this.dgMainCourse.SelectedRows[0].Index].Cells["MainCourseItem"].Value
						.ToString();

					Enum.TryParse(mainCourseItem, out Lunch.LunchOrderItem selectedMainCourse);

					this.dgAddOns.DataSource = this._lunch.AddOn
						.Where(addOn => addOn.MainCourseItem == selectedMainCourse).ToList();

					this.dgAddOns.ClearSelection();
					this.dgOrderSummary.DataSource = this._lunch.OrderSummary(
						this.dgMainCourse.SelectedRows[0],
						this.dgAddOns.SelectedRows);

					this.dgOrderSummary.ClearSelection();
					this.txtSubtotal.Text = this._lunch.SubTotal.ToString("C2");
				}
				else
				{
					this.dgAddOns.DataSource = null;
					this.dgOrderSummary.DataSource = null;
					this.txtSubtotal.Text = string.Empty;
				}
			}
		}

		private void dgAddOns_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dgAddOns.Focused)
			{
				this.dgOrderSummary.DataSource = this._lunch.OrderSummary(
					this.dgMainCourse.SelectedRows[0],
					this.dgAddOns.SelectedRows);
				this.txtSubtotal.Text = this._lunch.SubTotal.ToString("C2");
                this.dgOrderSummary.ClearSelection();
                this.dgOrderSummary.ClearSelection();
            }
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
