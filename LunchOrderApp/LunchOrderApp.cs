using System;
using System.Collections.Generic;
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
            this.dgMainCourse.DataSource = this._lunch.MainCourse;
	        this.dgMainCourse.Columns[0].Width = 30;
	        this.dgMainCourse.Columns[0].HeaderText = string.Empty;
	        this.dgMainCourse.Columns[1].AutoSizeMode =
		        DataGridViewAutoSizeColumnMode.Fill;
            this.dgMainCourse.Columns[2].DefaultCellStyle.Format = "c2";
	        this.dgMainCourse.ClearSelection();
	        this.dgOrderSummary.DataSource = null;
        }

	    private void dgMainCourse_SelectionChanged(object sender, EventArgs e)
	    {
		    if (this.dgMainCourse.Focused)
		    {
			    if (this.dgMainCourse.SelectedRows.Count != 0)
			    {
				    var mainCourseItem = this.dgMainCourse
					    .Rows[this.dgMainCourse.SelectedRows[0].Index].Cells[1].Value.ToString();

				    if (Enum.TryParse(mainCourseItem, out Lunch.LunchOrderItem selectedMainCourse))
				    {
					    this.dgAddOns.DataSource = this._lunch.AddOn
						    .Where(i => i.MainCourseItem == selectedMainCourse).ToList();

					    this.dgAddOns.Columns[0].Width = 30;
					    this.dgAddOns.Columns[0].HeaderText = string.Empty;
					    this.dgAddOns.Columns[1].Visible = false;
					    this.dgAddOns.Columns[2].AutoSizeMode =
						    DataGridViewAutoSizeColumnMode.Fill;
					    this.dgAddOns.Columns[3].DefaultCellStyle.Format = "c2";
					    this.dgAddOns.ClearSelection();

					    var order = new OrderSummary
					    {
						    Item = this.dgMainCourse.Rows[this.dgMainCourse.SelectedRows[0].Index]
							    .Cells[1].Value.ToString(),
						    Price = (decimal) this.dgMainCourse
							    .Rows[this.dgMainCourse.SelectedRows[0].Index].Cells[2].Value
					    };

					    var orderSummary = new List<OrderSummary> {order};
					    this.dgOrderSummary.DataSource = orderSummary;

					    foreach (DataGridViewColumn column in this.dgOrderSummary.Columns)
					    {
						    column.Width = this.dgOrderSummary.Width
							    / this.dgOrderSummary.ColumnCount;
					    }
                    }
			    }
			    else
			    {
				    this.dgAddOns.DataSource = null;
			    }
		    }
	    }



	    private void dgAddOns_SelectionChanged(object sender, EventArgs e)
        {
	        if (this.dgAddOns.Focused)
	        {
		        var orderList = (List<OrderSummary>)this.dgOrderSummary.DataSource;
		        this.dgOrderSummary.DataSource = null;
		        foreach (DataGridViewRow selectedRow in this.dgAddOns.SelectedRows)
		        {
			        var addOn = new OrderSummary
			        {
				        Item = selectedRow.Cells[2].Value.ToString(),
				        Price = (decimal) selectedRow.Cells[3].Value
			        };
			        orderList.Add(addOn);
			        this.dgOrderSummary.DataSource = orderList.Distinct().ToList();
		        }

		        foreach (DataGridViewColumn column in this.dgOrderSummary.Columns)
		        {
			        column.Width = this.dgOrderSummary.Width
				        / this.dgOrderSummary.ColumnCount;
		        }
				this.dgOrderSummary.ClearSelection();
            }
        }
    }
}
