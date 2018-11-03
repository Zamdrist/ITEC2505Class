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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMainCourse = new System.Windows.Forms.DataGridView();
            this.MainCourseImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainCourseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainCoursePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lblAddOns = new System.Windows.Forms.Label();
            this.dgAddOns = new System.Windows.Forms.DataGridView();
            this.AddOnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrderSunmary = new System.Windows.Forms.GroupBox();
            this.dgOrderSummary = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.OrderItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOns)).BeginInit();
            this.gbOrderSunmary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSummary)).BeginInit();
            this.gbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMainCourse
            // 
            this.dgMainCourse.AllowUserToAddRows = false;
            this.dgMainCourse.AllowUserToDeleteRows = false;
            this.dgMainCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMainCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainCourseImage,
            this.MainCourseItem,
            this.MainCoursePrice});
            this.dgMainCourse.Location = new System.Drawing.Point(27, 32);
            this.dgMainCourse.MultiSelect = false;
            this.dgMainCourse.Name = "dgMainCourse";
            this.dgMainCourse.ReadOnly = true;
            this.dgMainCourse.RowHeadersVisible = false;
            this.dgMainCourse.RowTemplate.Height = 24;
            this.dgMainCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgMainCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMainCourse.ShowEditingIcon = false;
            this.dgMainCourse.Size = new System.Drawing.Size(351, 165);
            this.dgMainCourse.TabIndex = 0;
            this.dgMainCourse.TabStop = false;
            this.dgMainCourse.SelectionChanged += new System.EventHandler(this.dgMainCourse_SelectionChanged);
            // 
            // MainCourseImage
            // 
            this.MainCourseImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MainCourseImage.DataPropertyName = "Image";
            this.MainCourseImage.HeaderText = "";
            this.MainCourseImage.Name = "MainCourseImage";
            this.MainCourseImage.ReadOnly = true;
            this.MainCourseImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainCourseImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MainCourseImage.Width = 30;
            // 
            // MainCourseItem
            // 
            this.MainCourseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MainCourseItem.DataPropertyName = "Item";
            this.MainCourseItem.HeaderText = "Item";
            this.MainCourseItem.Name = "MainCourseItem";
            this.MainCourseItem.ReadOnly = true;
            this.MainCourseItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainCoursePrice
            // 
            this.MainCoursePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MainCoursePrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.MainCoursePrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.MainCoursePrice.HeaderText = "Price";
            this.MainCoursePrice.Name = "MainCoursePrice";
            this.MainCoursePrice.ReadOnly = true;
            this.MainCoursePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dgAddOns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddOnImage,
            this.MainCourse,
            this.AddOnItem,
            this.AddOnPrice});
            this.dgAddOns.Location = new System.Drawing.Point(27, 233);
            this.dgAddOns.Name = "dgAddOns";
            this.dgAddOns.ReadOnly = true;
            this.dgAddOns.RowHeadersVisible = false;
            this.dgAddOns.RowTemplate.Height = 24;
            this.dgAddOns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgAddOns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddOns.ShowEditingIcon = false;
            this.dgAddOns.Size = new System.Drawing.Size(351, 165);
            this.dgAddOns.TabIndex = 2;
            this.dgAddOns.TabStop = false;
            this.dgAddOns.SelectionChanged += new System.EventHandler(this.dgAddOns_SelectionChanged);
            // 
            // AddOnImage
            // 
            this.AddOnImage.DataPropertyName = "Image";
            this.AddOnImage.HeaderText = "";
            this.AddOnImage.Name = "AddOnImage";
            this.AddOnImage.ReadOnly = true;
            this.AddOnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AddOnImage.Width = 30;
            // 
            // MainCourse
            // 
            this.MainCourse.DataPropertyName = "MainCourseItem";
            this.MainCourse.HeaderText = "";
            this.MainCourse.Name = "MainCourse";
            this.MainCourse.ReadOnly = true;
            this.MainCourse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainCourse.Visible = false;
            // 
            // AddOnItem
            // 
            this.AddOnItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddOnItem.DataPropertyName = "Item";
            this.AddOnItem.FillWeight = 10F;
            this.AddOnItem.HeaderText = "Item";
            this.AddOnItem.Name = "AddOnItem";
            this.AddOnItem.ReadOnly = true;
            this.AddOnItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddOnPrice
            // 
            this.AddOnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddOnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.AddOnPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddOnPrice.FillWeight = 5.988024F;
            this.AddOnPrice.HeaderText = "Price";
            this.AddOnPrice.Name = "AddOnPrice";
            this.AddOnPrice.ReadOnly = true;
            this.AddOnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dgOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItem,
            this.OrderPrice});
            this.dgOrderSummary.Enabled = false;
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
            this.dgOrderSummary.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(638, 62);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.Controls.Add(this.btnClearAll);
            this.gbOrderTotal.Controls.Add(this.btnExit);
            this.gbOrderTotal.Controls.Add(this.txtTotal);
            this.gbOrderTotal.Controls.Add(this.lblTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.txtSubtotal);
            this.gbOrderTotal.Controls.Add(this.lblSubTotal);
            this.gbOrderTotal.Location = new System.Drawing.Point(27, 444);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(761, 120);
            this.gbOrderTotal.TabIndex = 6;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSubtotal.Location = new System.Drawing.Point(100, 31);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 2;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(36, 31);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(68, 17);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Subtotal: ";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTax.Location = new System.Drawing.Point(100, 59);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(65, 62);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(39, 17);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax: ";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotal.Location = new System.Drawing.Point(100, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(56, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ";
            // 
            // btnClearAll
            // 
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearAll.Location = new System.Drawing.Point(638, 18);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(85, 35);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "C&lear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(24, 401);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(129, 17);
            this.lblHint.TabIndex = 7;
            this.lblHint.Text = "Ctrl + Click = Select";
            // 
            // OrderItem
            // 
            this.OrderItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderItem.DataPropertyName = "Item";
            this.OrderItem.HeaderText = "Item";
            this.OrderItem.Name = "OrderItem";
            this.OrderItem.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderPrice.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.OrderPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderPrice.HeaderText = "Price";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // LunchOrderApp
            // 
            this.AcceptButton = this.btnClearAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbOrderSunmary);
            this.Controls.Add(this.lblAddOns);
            this.Controls.Add(this.dgAddOns);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.dgMainCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LunchOrderApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order App";
            this.Load += new System.EventHandler(this.LunchOrderApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOns)).EndInit();
            this.gbOrderSunmary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderSummary)).EndInit();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
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
        private System.Windows.Forms.DataGridView 
	        dgOrderSummary;
        private System.Windows.Forms.DataGridViewImageColumn MainCourseImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainCourseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainCoursePrice;
        private System.Windows.Forms.DataGridViewImageColumn AddOnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddOnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddOnPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
    }
}

