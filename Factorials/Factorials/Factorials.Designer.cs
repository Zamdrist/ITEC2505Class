namespace Factorials
{
    partial class Factorials
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
            this.lblFactorials = new System.Windows.Forms.Label();
            this.udNumber = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFactorials
            // 
            this.lblFactorials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFactorials.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFactorials.Location = new System.Drawing.Point(12, 48);
            this.lblFactorials.Name = "lblFactorials";
            this.lblFactorials.Size = new System.Drawing.Size(191, 23);
            this.lblFactorials.TabIndex = 1;
            // 
            // udNumber
            // 
            this.udNumber.Location = new System.Drawing.Point(12, 14);
            this.udNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumber.Name = "udNumber";
            this.udNumber.ReadOnly = true;
            this.udNumber.Size = new System.Drawing.Size(191, 22);
            this.udNumber.TabIndex = 1;
            this.udNumber.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udNumber.ValueChanged += new System.EventHandler(this.udNumber_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 81);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Factorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 124);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.udNumber);
            this.Controls.Add(this.lblFactorials);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factorials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorials";
            this.Load += new System.EventHandler(this.Factorials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFactorials;
        private System.Windows.Forms.NumericUpDown udNumber;
        private System.Windows.Forms.Button btnExit;
    }
}

