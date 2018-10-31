namespace LunchOrderApp
{
    partial class LunchOrderApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgMainCourse = new System.Windows.Forms.DataGridView();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lblAddOns = new System.Windows.Forms.Label();
            this.dgAddOns = new System.Windows.Forms.DataGridView();
            this.gbOrderSunmary = new System.Windows.Forms.GroupBox();
            this.dgOrderSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOns)).BeginInit();
            this.gbOrderSunmary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMainCourse
            // 
            this.dgMainCourse.AllowUserToAddRows = false;
            this.dgMainCourse.AllowUserToDeleteRows = false;
            this.dgMainCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMainCourse.Location = new System.Drawing.Point(27, 32);
            this.dgMainCourse.MultiSelect = false;
            this.dgMainCourse.Name = "dgMainCourse";
            this.dgMainCourse.ReadOnly = true;
            this.dgMainCourse.RowHeadersVisible = false;
            this.dgMainCourse.RowTemplate.Height = 24;
            this.dgMainCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMainCourse.ShowEditingIcon = false;
            this.dgMainCourse.Size = new System.Drawing.Size(351, 165);
            this.dgMainCourse.TabIndex = 0;
            this.dgMainCourse.SelectionChanged += new System.EventHandler(this.dgMainCourse_SelectionChanged);
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCourse.Location = new System.Drawing.Point(24, 12);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(87, 17);
            this.lblMainCourse.TabIndex = 1;
            this.lblMainCourse.Text = "Main Course";
            // 
            // lblAddOns
            // 
            this.lblAddOns.AutoSize = true;
            this.lblAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOns.Location = new System.Drawing.Point(24, 213);
            this.lblAddOns.Name = "lblAddOns";
            this.lblAddOns.Size = new System.Drawing.Size(61, 17);
            this.lblAddOns.TabIndex = 3;
            this.lblAddOns.Text = "Add-ons";
            // 
            // dgAddOns
            // 
            this.dgAddOns.AllowUserToAddRows = false;
            this.dgAddOns.AllowUserToDeleteRows = false;
            this.dgAddOns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddOns.Location = new System.Drawing.Point(27, 233);
            this.dgAddOns.Name = "dgAddOns";
            this.dgAddOns.ReadOnly = true;
            this.dgAddOns.RowHeadersVisible = false;
            this.dgAddOns.RowTemplate.Height = 24;
            this.dgAddOns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddOns.ShowEditingIcon = false;
            this.dgAddOns.Size = new System.Drawing.Size(351, 165);
            this.dgAddOns.TabIndex = 2;
            this.dgAddOns.SelectionChanged += new System.EventHandler(this.dgAddOns_SelectionChanged);
            // 
            // gbOrderSunmary
            // 
            this.gbOrderSunmary.Controls.Add(this.dgOrderSummary);
            this.gbOrderSunmary.Location = new System.Drawing.Point(398, 12);
            this.gbOrderSunmary.Name = "gbOrderSunmary";
            this.gbOrderSunmary.Size = new System.Drawing.Size(390, 386);
            this.gbOrderSunmary.TabIndex = 4;
            this.gbOrderSunmary.TabStop = false;
            this.gbOrderSunmary.Text = "Order Summary";
            // 
            // dgOrderSummary
            // 
            this.dgOrderSummary.AllowUserToAddRows = false;
            this.dgOrderSummary.AllowUserToDeleteRows = false;
            this.dgOrderSummary.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderSummary.Location = new System.Drawing.Point(20, 35);
            this.dgOrderSummary.MultiSelect = false;
            this.dgOrderSummary.Name = "dgOrderSummary";
            this.dgOrderSummary.ReadOnly = true;
            this.dgOrderSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOrderSummary.RowHeadersVisible = false;
            this.dgOrderSummary.RowTemplate.Height = 24;
            this.dgOrderSummary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgOrderSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderSummary.Size = new System.Drawing.Size(350, 327);
            this.dgOrderSummary.TabIndex = 0;
            // 
            // LunchOrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.gbOrderSunmary);
            this.Controls.Add(this.lblAddOns);
            this.Controls.Add(this.dgAddOns);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.dgMainCourse);
            this.Name = "LunchOrderApp";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.LunchOrderApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOns)).EndInit();
            this.gbOrderSunmary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMainCourse;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.Label lblAddOns;
        private System.Windows.Forms.DataGridView dgAddOns;
        private System.Windows.Forms.GroupBox gbOrderSunmary;
        private System.Windows.Forms.Label lblSelectedMainCourseItem;
        private System.Windows.Forms.DataGridView dgOrderSummary;
    }
}

