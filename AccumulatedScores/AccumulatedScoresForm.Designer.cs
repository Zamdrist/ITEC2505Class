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
            this.btnDisplayScores = new System.Windows.Forms.Button();
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
            this.txtScore.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(174, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(263, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 192);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(44, 190);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(124, 28);
            this.btnDisplayScores.TabIndex = 11;
            this.btnDisplayScores.Text = "&Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            // 
            // AccumulatedScoresForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(356, 228);
            this.Controls.Add(this.btnDisplayScores);
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
        private System.Windows.Forms.Button btnDisplayScores;
    }
}

