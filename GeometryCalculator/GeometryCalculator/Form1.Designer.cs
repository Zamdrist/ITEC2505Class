namespace GeometryCalculator
{
    partial class frnGeometryCalculator
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
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbTrapezoid = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbRhombus = new System.Windows.Forms.RadioButton();
            this.rbParallelogram = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.grpDimensions = new System.Windows.Forms.GroupBox();
            this.rbAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.rbPerimeter = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.txtRectangleLength = new System.Windows.Forms.TextBox();
            this.txtRectangleWidth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.txtSideD = new System.Windows.Forms.TextBox();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.lblSideD = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.kiteBtn = new System.Windows.Forms.RadioButton();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.percentTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpShapes.SuspendLayout();
            this.grpDimensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.kiteBtn);
            this.grpShapes.Controls.Add(this.rbCircle);
            this.grpShapes.Controls.Add(this.rbTrapezoid);
            this.grpShapes.Controls.Add(this.rbTriangle);
            this.grpShapes.Controls.Add(this.rbRhombus);
            this.grpShapes.Controls.Add(this.rbParallelogram);
            this.grpShapes.Controls.Add(this.rbSquare);
            this.grpShapes.Controls.Add(this.rbRectangle);
            this.grpShapes.Location = new System.Drawing.Point(12, 221);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(196, 278);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(34, 197);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(64, 21);
            this.rbCircle.TabIndex = 6;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbTrapezoid
            // 
            this.rbTrapezoid.AutoSize = true;
            this.rbTrapezoid.Location = new System.Drawing.Point(34, 170);
            this.rbTrapezoid.Name = "rbTrapezoid";
            this.rbTrapezoid.Size = new System.Drawing.Size(93, 21);
            this.rbTrapezoid.TabIndex = 5;
            this.rbTrapezoid.TabStop = true;
            this.rbTrapezoid.Text = "Trapezoid";
            this.rbTrapezoid.UseVisualStyleBackColor = true;
            this.rbTrapezoid.CheckedChanged += new System.EventHandler(this.rbTrapezoid_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(34, 143);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(81, 21);
            this.rbTriangle.TabIndex = 4;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbRhombus
            // 
            this.rbRhombus.AutoSize = true;
            this.rbRhombus.Location = new System.Drawing.Point(34, 116);
            this.rbRhombus.Name = "rbRhombus";
            this.rbRhombus.Size = new System.Drawing.Size(89, 21);
            this.rbRhombus.TabIndex = 3;
            this.rbRhombus.TabStop = true;
            this.rbRhombus.Text = "Rhombus";
            this.rbRhombus.UseVisualStyleBackColor = true;
            this.rbRhombus.CheckedChanged += new System.EventHandler(this.rbRhombus_CheckedChanged);
            // 
            // rbParallelogram
            // 
            this.rbParallelogram.AutoSize = true;
            this.rbParallelogram.Location = new System.Drawing.Point(34, 89);
            this.rbParallelogram.Name = "rbParallelogram";
            this.rbParallelogram.Size = new System.Drawing.Size(116, 21);
            this.rbParallelogram.TabIndex = 2;
            this.rbParallelogram.TabStop = true;
            this.rbParallelogram.Text = "Parallelogram";
            this.rbParallelogram.UseVisualStyleBackColor = true;
            this.rbParallelogram.CheckedChanged += new System.EventHandler(this.rbParallelogram_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(34, 62);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(75, 21);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(34, 35);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(93, 21);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // grpDimensions
            // 
            this.grpDimensions.Controls.Add(this.rbAreaPerimeter);
            this.grpDimensions.Controls.Add(this.rbPerimeter);
            this.grpDimensions.Controls.Add(this.rbArea);
            this.grpDimensions.Location = new System.Drawing.Point(12, 12);
            this.grpDimensions.Name = "grpDimensions";
            this.grpDimensions.Size = new System.Drawing.Size(196, 184);
            this.grpDimensions.TabIndex = 1;
            this.grpDimensions.TabStop = false;
            this.grpDimensions.Text = "Dimensions";
            // 
            // rbAreaPerimeter
            // 
            this.rbAreaPerimeter.AutoSize = true;
            this.rbAreaPerimeter.Location = new System.Drawing.Point(22, 93);
            this.rbAreaPerimeter.Name = "rbAreaPerimeter";
            this.rbAreaPerimeter.Size = new System.Drawing.Size(137, 21);
            this.rbAreaPerimeter.TabIndex = 2;
            this.rbAreaPerimeter.Text = "Area && Perimeter";
            this.rbAreaPerimeter.UseVisualStyleBackColor = true;
            // 
            // rbPerimeter
            // 
            this.rbPerimeter.AutoSize = true;
            this.rbPerimeter.Location = new System.Drawing.Point(22, 66);
            this.rbPerimeter.Name = "rbPerimeter";
            this.rbPerimeter.Size = new System.Drawing.Size(90, 21);
            this.rbPerimeter.TabIndex = 1;
            this.rbPerimeter.Text = "Perimeter";
            this.rbPerimeter.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(22, 39);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(59, 21);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.rbArea_CheckedChanged);
            // 
            // txtRectangleLength
            // 
            this.txtRectangleLength.Location = new System.Drawing.Point(299, 47);
            this.txtRectangleLength.Name = "txtRectangleLength";
            this.txtRectangleLength.Size = new System.Drawing.Size(100, 22);
            this.txtRectangleLength.TabIndex = 2;
            this.txtRectangleLength.Text = "0";
            this.txtRectangleLength.Visible = false;
            // 
            // txtRectangleWidth
            // 
            this.txtRectangleWidth.Location = new System.Drawing.Point(299, 74);
            this.txtRectangleWidth.Name = "txtRectangleWidth";
            this.txtRectangleWidth.Size = new System.Drawing.Size(100, 22);
            this.txtRectangleWidth.TabIndex = 3;
            this.txtRectangleWidth.Text = "0";
            this.txtRectangleWidth.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(237, 51);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
            this.lblLength.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(240, 78);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(299, 402);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 38);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(243, 341);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(46, 17);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(243, 358);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(77, 17);
            this.lblPerimeter.TabIndex = 10;
            this.lblPerimeter.Text = "Perimeter: ";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(240, 105);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(43, 17);
            this.lblSides.TabIndex = 11;
            this.lblSides.Text = "Sides";
            this.lblSides.Visible = false;
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(300, 105);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(100, 22);
            this.txtSides.TabIndex = 12;
            this.txtSides.Text = "0";
            this.txtSides.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(300, 133);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 13;
            this.txtBase.Text = "0";
            this.txtBase.Visible = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(299, 162);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "0";
            this.txtHeight.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(243, 136);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 15;
            this.lblBase.Text = "Base";
            this.lblBase.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(243, 166);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 16;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(300, 190);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 22);
            this.txtSideA.TabIndex = 17;
            this.txtSideA.Text = "0";
            this.txtSideA.Visible = false;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(300, 218);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 22);
            this.txtSideB.TabIndex = 18;
            this.txtSideB.Text = "0";
            this.txtSideB.Visible = false;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(300, 246);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 22);
            this.txtSideC.TabIndex = 19;
            this.txtSideC.Text = "0";
            this.txtSideC.Visible = false;
            // 
            // txtSideD
            // 
            this.txtSideD.Location = new System.Drawing.Point(300, 274);
            this.txtSideD.Name = "txtSideD";
            this.txtSideD.Size = new System.Drawing.Size(100, 22);
            this.txtSideD.TabIndex = 20;
            this.txtSideD.Text = "0";
            this.txtSideD.Visible = false;
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(237, 199);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(49, 17);
            this.lblSideA.TabIndex = 21;
            this.lblSideA.Text = "Side A";
            this.lblSideA.Visible = false;
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(237, 221);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(49, 17);
            this.lblSideB.TabIndex = 22;
            this.lblSideB.Text = "Side B";
            this.lblSideB.Visible = false;
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(237, 246);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(49, 17);
            this.lblSideC.TabIndex = 23;
            this.lblSideC.Text = "Side C";
            this.lblSideC.Visible = false;
            // 
            // lblSideD
            // 
            this.lblSideD.AutoSize = true;
            this.lblSideD.Location = new System.Drawing.Point(239, 273);
            this.lblSideD.Name = "lblSideD";
            this.lblSideD.Size = new System.Drawing.Size(50, 17);
            this.lblSideD.TabIndex = 24;
            this.lblSideD.Text = "Side D";
            this.lblSideD.Visible = false;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(299, 309);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 25;
            this.txtRadius.Text = "0";
            this.txtRadius.Visible = false;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(243, 309);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 26;
            this.lblRadius.Text = "Radius";
            this.lblRadius.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(299, 446);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 38);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // kiteBtn
            // 
            this.kiteBtn.AutoSize = true;
            this.kiteBtn.Location = new System.Drawing.Point(34, 225);
            this.kiteBtn.Name = "kiteBtn";
            this.kiteBtn.Size = new System.Drawing.Size(53, 21);
            this.kiteBtn.TabIndex = 7;
            this.kiteBtn.TabStop = true;
            this.kiteBtn.Text = "Kite";
            this.kiteBtn.UseVisualStyleBackColor = true;
            this.kiteBtn.CheckedChanged += new System.EventHandler(this.kiteBtn_CheckedChanged);
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(568, 51);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(100, 22);
            this.numberTxt.TabIndex = 28;
            // 
            // percentTxt
            // 
            this.percentTxt.Location = new System.Drawing.Point(568, 90);
            this.percentTxt.Name = "percentTxt";
            this.percentTxt.Size = new System.Drawing.Size(100, 22);
            this.percentTxt.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Percent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Calculate Percentage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(704, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 17);
            this.lblResult.TabIndex = 33;
            this.lblResult.Text = "Result: ";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // frnGeometryCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(780, 554);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percentTxt);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblSideD);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.txtSideD);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtRectangleWidth);
            this.Controls.Add(this.txtRectangleLength);
            this.Controls.Add(this.grpDimensions);
            this.Controls.Add(this.grpShapes);
            this.Name = "frnGeometryCalculator";
            this.Text = "Geometry Calculator";
            this.Load += new System.EventHandler(this.frnGeometryCalculator_Load);
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpDimensions.ResumeLayout(false);
            this.grpDimensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbTrapezoid;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRhombus;
        private System.Windows.Forms.RadioButton rbParallelogram;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox grpDimensions;
        private System.Windows.Forms.RadioButton rbAreaPerimeter;
        private System.Windows.Forms.RadioButton rbPerimeter;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.TextBox txtRectangleLength;
        private System.Windows.Forms.TextBox txtRectangleWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.TextBox txtSideD;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.Label lblSideD;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RadioButton kiteBtn;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.TextBox percentTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}

