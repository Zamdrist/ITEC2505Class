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
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMainCourse
            // 
            this.dgMainCourse.AllowUserToAddRows = false;
            this.dgMainCourse.AllowUserToDeleteRows = false;
            this.dgMainCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMainCourse.Location = new System.Drawing.Point(62, 72);
            this.dgMainCourse.Name = "dgMainCourse";
            this.dgMainCourse.ReadOnly = true;
            this.dgMainCourse.RowTemplate.Height = 24;
            this.dgMainCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMainCourse.Size = new System.Drawing.Size(550, 311);
            this.dgMainCourse.TabIndex = 0;
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCourse.Location = new System.Drawing.Point(59, 52);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(87, 17);
            this.lblMainCourse.TabIndex = 1;
            this.lblMainCourse.Text = "Main Course";
            // 
            // LunchOrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.dgMainCourse);
            this.Name = "LunchOrderApp";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMainCourse;
        private System.Windows.Forms.Label lblMainCourse;
    }
}

