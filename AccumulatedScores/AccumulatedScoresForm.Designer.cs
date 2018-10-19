namespace AccumulatedScores
{
    partial class AccumulatedScoresForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblScoreAverage = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScoreTotalValue = new System.Windows.Forms.Label();
            this.lblScoreAverageValue = new System.Windows.Forms.Label();
            this.lblScoreCountValue = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnShowScore = new System.Windows.Forms.Button();
            this.lblScoreMinValue = new System.Windows.Forms.Label();
            this.lblScoreMin = new System.Windows.Forms.Label();
            this.lblScoreMaxValue = new System.Windows.Forms.Label();
            this.lnlScoreMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(41, 29);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 17);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(41, 65);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(81, 17);
            this.lblScoreTotal.TabIndex = 1;
            this.lblScoreTotal.Text = "Score Total";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(41, 106);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(86, 17);
            this.lblScoreCount.TabIndex = 2;
            this.lblScoreCount.Text = "Score Count";
            // 
            // lblScoreAverage
            // 
            this.lblScoreAverage.AutoSize = true;
            this.lblScoreAverage.Location = new System.Drawing.Point(41, 144);
            this.lblScoreAverage.Name = "lblScoreAverage";
            this.lblScoreAverage.Size = new System.Drawing.Size(61, 17);
            this.lblScoreAverage.TabIndex = 3;
            this.lblScoreAverage.Text = "Average";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(141, 26);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(104, 22);
            this.txtScore.TabIndex = 0;
            // 
            // lblScoreTotalValue
            // 
            this.lblScoreTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreTotalValue.Location = new System.Drawing.Point(141, 65);
            this.lblScoreTotalValue.Name = "lblScoreTotalValue";
            this.lblScoreTotalValue.Size = new System.Drawing.Size(104, 24);
            this.lblScoreTotalValue.TabIndex = 5;
            // 
            // lblScoreAverageValue
            // 
            this.lblScoreAverageValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreAverageValue.Location = new System.Drawing.Point(141, 144);
            this.lblScoreAverageValue.Name = "lblScoreAverageValue";
            this.lblScoreAverageValue.Size = new System.Drawing.Size(104, 24);
            this.lblScoreAverageValue.TabIndex = 6;
            // 
            // lblScoreCountValue
            // 
            this.lblScoreCountValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreCountValue.Location = new System.Drawing.Point(141, 105);
            this.lblScoreCountValue.Name = "lblScoreCountValue";
            this.lblScoreCountValue.Size = new System.Drawing.Size(104, 24);
            this.lblScoreCountValue.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(285, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 107);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(285, 105);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(79, 34);
            this.btnClearScores.TabIndex = 3;
            this.btnClearScores.Text = "Clea&r";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnShowScore
            // 
            this.btnShowScore.Location = new System.Drawing.Point(285, 65);
            this.btnShowScore.Name = "btnShowScore";
            this.btnShowScore.Size = new System.Drawing.Size(79, 34);
            this.btnShowScore.TabIndex = 2;
            this.btnShowScore.Text = "&Show Scores";
            this.btnShowScore.UseVisualStyleBackColor = true;
            this.btnShowScore.Click += new System.EventHandler(this.btnShowScore_Click);
            // 
            // lblScoreMinValue
            // 
            this.lblScoreMinValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreMinValue.Location = new System.Drawing.Point(141, 227);
            this.lblScoreMinValue.Name = "lblScoreMinValue";
            this.lblScoreMinValue.Size = new System.Drawing.Size(104, 24);
            this.lblScoreMinValue.TabIndex = 14;
            // 
            // lblScoreMin
            // 
            this.lblScoreMin.AutoSize = true;
            this.lblScoreMin.Location = new System.Drawing.Point(41, 227);
            this.lblScoreMin.Name = "lblScoreMin";
            this.lblScoreMin.Size = new System.Drawing.Size(71, 17);
            this.lblScoreMin.TabIndex = 13;
            this.lblScoreMin.Text = "Min Score";
            // 
            // lblScoreMaxValue
            // 
            this.lblScoreMaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreMaxValue.Location = new System.Drawing.Point(141, 183);
            this.lblScoreMaxValue.Name = "lblScoreMaxValue";
            this.lblScoreMaxValue.Size = new System.Drawing.Size(104, 24);
            this.lblScoreMaxValue.TabIndex = 16;
            // 
            // lnlScoreMax
            // 
            this.lnlScoreMax.AutoSize = true;
            this.lnlScoreMax.Location = new System.Drawing.Point(41, 183);
            this.lnlScoreMax.Name = "lnlScoreMax";
            this.lnlScoreMax.Size = new System.Drawing.Size(74, 17);
            this.lnlScoreMax.TabIndex = 15;
            this.lnlScoreMax.Text = "Max Score";
            // 
            // AccumulatedScoresForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(387, 264);
            this.Controls.Add(this.lblScoreMaxValue);
            this.Controls.Add(this.lnlScoreMax);
            this.Controls.Add(this.lblScoreMinValue);
            this.Controls.Add(this.lblScoreMin);
            this.Controls.Add(this.btnShowScore);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblScoreCountValue);
            this.Controls.Add(this.lblScoreAverageValue);
            this.Controls.Add(this.lblScoreTotalValue);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScoreAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccumulatedScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accumulated Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblScoreAverage;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScoreTotalValue;
        private System.Windows.Forms.Label lblScoreAverageValue;
        private System.Windows.Forms.Label lblScoreCountValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnShowScore;
        private System.Windows.Forms.Label lblScoreMinValue;
        private System.Windows.Forms.Label lblScoreMin;
        private System.Windows.Forms.Label lblScoreMaxValue;
        private System.Windows.Forms.Label lnlScoreMax;
    }
}

