using System;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public partial class LunchOrderApp : Form
    {
        public LunchOrderApp()
        {
            this.InitializeComponent();
        }

        private void LunchOrderApp_Load(object sender, EventArgs e)
        {
	        var lunch = new Lunch();
            this.dgMainCourse.DataSource = lunch.MainCourse;
            this.dgMainCourse.Columns[2].DefaultCellStyle.Format = "c2";
	        //this.dgMainCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
	        this.dgMainCourse.Columns[0].Width = 30;
	        this.dgMainCourse.Columns[0].HeaderText = string.Empty;


        }

        private void dgMainCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
	        foreach (DataGridViewColumn column in this.dgMainCourse.Columns)
	        {
		        //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
	        }
        }
    }
}
