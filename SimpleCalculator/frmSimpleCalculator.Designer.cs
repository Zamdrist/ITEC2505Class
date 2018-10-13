namespace SimpleCalculator
{
    partial class FormSimpleCalculator
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Location = new System.Drawing.Point(16, 339);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 31);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(194, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(29, 55);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(76, 17);
            this.lblOperand1.TabIndex = 2;
            this.lblOperand1.Text = "Operand 1";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(29, 96);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(65, 17);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "Operator";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(29, 141);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(76, 17);
            this.lblOperand2.TabIndex = 4;
            this.lblOperand2.Text = "Operand 2";
            // 
            // lblResultValue
            // 
            this.lblResultValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultValue.Location = new System.Drawing.Point(143, 182);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(137, 23);
            this.lblResultValue.TabIndex = 3;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(143, 141);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(137, 22);
            this.txtOperand2.TabIndex = 2;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(143, 96);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(40, 22);
            this.txtOperator.TabIndex = 1;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(143, 55);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(137, 22);
            this.txtOperand1.TabIndex = 0;
            // 
            // FormSimpleCalculator
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(317, 382);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperand1;
    }
}

