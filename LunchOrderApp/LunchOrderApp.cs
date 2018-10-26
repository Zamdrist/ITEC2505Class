using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public partial class LunchOrderApp : Form
    {
        public LunchOrderApp()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lunch = new Lunch();
            this.dgMainCourse.DataSource = lunch.MainCourse;
            this.dgMainCourse.Columns[1].DefaultCellStyle.Format = "c2";
            this.dgMainCourse.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
    }
}
