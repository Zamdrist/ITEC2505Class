namespace RectangleWithValidation
{
    partial class FormRectangle
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblPerimeterValue = new System.Windows.Forms.Label();
            this.lblAreaValue = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLengthRequired = new System.Windows.Forms.Label();
            this.lblWidthRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(35, 10);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(38, 30);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(208, 22);
            this.txtLength.TabIndex = 0;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(38, 82);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(208, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(35, 62);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(33, 156);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(33, 196);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(69, 17);
            this.lblPerimeter.TabIndex = 6;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // lblPerimeterValue
            // 
            this.lblPerimeterValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerimeterValue.Location = new System.Drawing.Point(135, 195);
            this.lblPerimeterValue.Name = "lblPerimeterValue";
            this.lblPerimeterValue.Size = new System.Drawing.Size(111, 27);
            this.lblPerimeterValue.TabIndex = 8;
            // 
            // lblAreaValue
            // 
            this.lblAreaValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAreaValue.Location = new System.Drawing.Point(135, 155);
            this.lblAreaValue.Name = "lblAreaValue";
            this.lblAreaValue.Size = new System.Drawing.Size(111, 27);
            this.lblAreaValue.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 246);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 29);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(165, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLengthRequired
            // 
            this.lblLengthRequired.AutoSize = true;
            this.lblLengthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthRequired.ForeColor = System.Drawing.Color.Red;
            this.lblLengthRequired.Location = new System.Drawing.Point(232, 15);
            this.lblLengthRequired.Name = "lblLengthRequired";
            this.lblLengthRequired.Size = new System.Drawing.Size(10, 12);
            this.lblLengthRequired.TabIndex = 9;
            this.lblLengthRequired.Text = "*";
            // 
            // lblWidthRequired
            // 
            this.lblWidthRequired.AutoSize = true;
            this.lblWidthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthRequired.ForeColor = System.Drawing.Color.Red;
            this.lblWidthRequired.Location = new System.Drawing.Point(232, 67);
            this.lblWidthRequired.Name = "lblWidthRequired";
            this.lblWidthRequired.Size = new System.Drawing.Size(10, 12);
            this.lblWidthRequired.TabIndex = 10;
            this.lblWidthRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(56, 116);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(66, 17);
            this.lblRequired.TabIndex = 12;
            this.lblRequired.Text = "Required";
            // 
            // frmRectangle
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(279, 287);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWidthRequired);
            this.Controls.Add(this.lblLengthRequired);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPerimeterValue);
            this.Controls.Add(this.lblAreaValue);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblPerimeterValue;
        private System.Windows.Forms.Label lblAreaValue;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLengthRequired;
        private System.Windows.Forms.Label lblWidthRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRequired;
    }
}

