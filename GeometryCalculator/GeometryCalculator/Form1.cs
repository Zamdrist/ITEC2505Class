using System;
using System.Linq;
using System.Windows.Forms;

namespace GeometryCalculator
{
	public partial class frnGeometryCalculator : Form
	{
		public frnGeometryCalculator()
		{
			InitializeComponent();
		}

		private void rbRectangle_CheckedChanged(object sender, EventArgs e)
		{
			this.txtRectangleLength.Visible = this.rbRectangle.Checked;
			this.txtRectangleWidth.Visible = this.rbRectangle.Checked;
			this.lblLength.Visible = this.rbRectangle.Checked;
			this.lblWidth.Visible = this.rbRectangle.Checked;
			this.TextChange();
		}

		private void rbArea_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{


				//IF RECTANGLE IS CHECKED
				if (this.rbRectangle.Checked)
				{
					if (this.IsValid(this.txtRectangleLength, "")
						&& this.IsValid(this.txtRectangleWidth, ""))
					{


						var length = Convert.ToDecimal(this.txtRectangleLength.Text);
						var width = Convert.ToDecimal(this.txtRectangleWidth.Text);
						if (this.rbArea.Checked)
						{
							var area = length * width;
							this.lblArea.Text = "Area: " + area;

						}
						else if (this.rbPerimeter.Checked)
						{
							var perimeter = 2 * length + 2 * width;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{
							var area = length * width;
							var perimeter = 2 * length + 2 * width;
							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF SQUARE IS CHECKED
				if (this.rbSquare.Checked)
				{
					if (this.IsValid(this.txtSides, ""))
					{
						var sides = Convert.ToDecimal(this.txtSides.Text);

						if (this.rbArea.Checked)
						{
							var area = sides * sides;
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							var perimeter = sides * 4;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{
							var area = sides * sides;
							var perimeter = sides * 4;
							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF PARALLELOGRAM IS CHECKED
				if (this.rbParallelogram.Checked)
				{
					if (this.IsValid(this.txtHeight, "")
						&& this.IsValid(this.txtSideA, "")
						&& this.IsValid(this.txtSideB, "")
						&& this.IsValid(this.txtSideC, "")
						&& this.IsValid(this.txtSideD, "")
						&& this.IsValid(this.txtBase, ""))
					{
						var baseValue = Convert.ToDecimal(this.txtBase.Text);
						var height = Convert.ToDecimal(this.txtHeight.Text);
						var sideA = Convert.ToDecimal(this.txtSideA.Text);
						var sideB = Convert.ToDecimal(this.txtSideB.Text);
						var sideC = Convert.ToDecimal(this.txtSideC.Text);
						var sideD = Convert.ToDecimal(this.txtSideD.Text);

						if (this.rbArea.Checked)
						{

							var area = baseValue * height;
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							var perimeter = sideA + sideB + sideC + sideD;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{
							var area = baseValue * height;
							var perimeter = sideA + sideB + sideC + sideD;
							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF RHOMBUS IS CHECKED
				if (this.rbRhombus.Checked)
				{
					if (this.IsValid(this.txtBase, "")
						&& this.IsValid(this.txtHeight, ""))
					{
						var baseValue = Convert.ToDecimal(this.txtBase.Text);
						var height = Convert.ToDecimal(this.txtHeight.Text);

						var area = height * baseValue;
						var perimeter = baseValue * 4;

						if (this.rbArea.Checked)
						{
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{

							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF TRIANGLE IS CHECKED
				if (this.rbTriangle.Checked)
				{
					if (this.IsValid(this.txtHeight, "")
						&& this.IsValid(this.txtSideA, "")
						&& this.IsValid(this.txtSideB, "")
						&& this.IsValid(this.txtSideC, "")
						&& this.IsValid(this.txtBase, ""))
					{

						var baseValue = Convert.ToDecimal(this.txtBase.Text);
						var height = Convert.ToDecimal(this.txtHeight.Text);
						var sideA = Convert.ToDecimal(this.txtSideA.Text);
						var sideB = Convert.ToDecimal(this.txtSideB.Text);
						var sideC = Convert.ToDecimal(this.txtSideC.Text);

						var area = height * baseValue / 2;
						var perimeter = sideA + sideB + sideC;

						if (this.rbArea.Checked)
						{
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{

							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF TRAPEZOID IS CHECKED
				if (this.rbTrapezoid.Checked)
				{
					if (this.IsValid(this.txtHeight, "")
						&& this.IsValid(this.txtSideA, "")
						&& this.IsValid(this.txtSideB, "")
						&& this.IsValid(this.txtSideC, "")
						&& this.IsValid(this.txtSideD, ""))
					{

						var height = Convert.ToDecimal(this.txtHeight.Text);
						var sideA = Convert.ToDecimal(this.txtSideA.Text);
						var sideB = Convert.ToDecimal(this.txtSideB.Text);
						var sideC = Convert.ToDecimal(this.txtSideC.Text);
						var sideD = Convert.ToDecimal(this.txtSideD.Text);

						var area = (sideA + sideB) / 2 * height;
						var perimeter = sideA + sideB + sideC + sideD;

						if (this.rbArea.Checked)
						{
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{

							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

				//IF CIRCLE IS CHECKED
				if (this.rbCircle.Checked)
				{
					if (this.IsValid(this.txtRadius, ""))
					{

						var myPi = (decimal) Math.Round(Math.PI, 2);
						var radius = Convert.ToDecimal(this.txtRadius.Text);

						var area = myPi * (radius * radius);
						var perimeter = 2 * myPi * radius;

						if (this.rbArea.Checked)
						{
							this.lblArea.Text = "Area: " + area;
						}
						else if (this.rbPerimeter.Checked)
						{
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{

							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
					}
				}

                //IF KITE IS CHECKED
				if (this.kiteBtn.Checked)
				{
					if (this.IsValid(this.txtHeight, "")&&
						this.IsValid(this.txtRectangleWidth, "") &&
						this.IsValid(this.txtSideA, "") &&
						this.IsValid(this.txtSideB, ""))
					{


						var height = Convert.ToDecimal(this.txtHeight.Text);
						var width = Convert.ToDecimal(this.txtRectangleWidth.Text);
						var sideA = Convert.ToDecimal(this.txtSideA.Text);
						var sideB = Convert.ToDecimal(this.txtSideB.Text);

						var area = height * width / 2;
						var perimeter = (sideA + sideB) * 2;

						if (this.rbArea.Checked)
						{
							this.lblArea.Text = "Area: " + area;

						}
						else if (this.rbPerimeter.Checked)
						{
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
						}
						else if (this.rbAreaPerimeter.Checked)
						{
							this.lblArea.Text = "Area: " + area;
							this.lblPerimeter.Text = "Perimeter: " + perimeter;
                        }
					}
				}
            }
			catch (Exception exception)
			{

				Console.WriteLine(exception);
				throw;
			}
		}

        private void exitBtn_Click(object sender, EventArgs e)
        {
	        this.Close();
        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtSides.Visible = this.rbSquare.Checked;
	        this.lblSides.Visible = this.rbSquare.Checked;
			this.TextChange();

        }

        private void rbParallelogram_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtBase.Visible = this.rbParallelogram.Checked;
	        this.txtHeight.Visible = this.rbParallelogram.Checked;
	        this.txtSideA.Visible = this.rbParallelogram.Checked;
	        this.txtSideB.Visible = this.rbParallelogram.Checked;
	        this.lblBase.Visible = this.rbParallelogram.Checked;
	        this.lblHeight.Visible = this.rbParallelogram.Checked;
	        this.lblSideA.Visible = this.rbParallelogram.Checked;
	        this.lblSideB.Visible = this.rbParallelogram.Checked;
			this.TextChange();
        }

        private void rbRhombus_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtBase.Visible = this.rbRhombus.Checked;
	        this.txtHeight.Visible = this.rbRhombus.Checked;
	        this.txtSideB.Visible = this.rbRhombus.Checked;
	        this.lblBase.Visible = this.rbRhombus.Checked;
	        this.lblHeight.Visible = this.rbRhombus.Checked;
	        this.lblSideB.Visible = this.rbRhombus.Checked;
			this.TextChange();
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtBase.Visible = this.rbTriangle.Checked;
	        this.txtHeight.Visible = this.rbTriangle.Checked;
	        this.txtSideA.Visible = this.rbTriangle.Checked;
	        this.txtSideB.Visible = this.rbTriangle.Checked;
	        this.txtSideC.Visible = this.rbTriangle.Checked;
	        this.lblBase.Visible = this.rbTriangle.Checked;
	        this.lblHeight.Visible = this.rbTriangle.Checked;
	        this.lblSideA.Visible = this.rbTriangle.Checked;
	        this.lblSideB.Visible = this.rbTriangle.Checked;
	        this.lblSideC.Visible = this.rbTriangle.Checked;
			this.TextChange();

        }

        private void rbTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtSideA.Visible = this.rbTrapezoid.Checked;
	        this.txtSideB.Visible = this.rbTrapezoid.Checked;
	        this.txtSideC.Visible = this.rbTrapezoid.Checked;
	        this.txtSideD.Visible = this.rbTrapezoid.Checked;
	        this.txtHeight.Visible = this.rbTrapezoid.Checked;
	        this.lblSideA.Visible = this.rbTrapezoid.Checked;
	        this.lblSideB.Visible = this.rbTrapezoid.Checked;
	        this.lblSideC.Visible = this.rbTrapezoid.Checked;
	        this.lblSideD.Visible = this.rbTrapezoid.Checked;
	        this.lblHeight.Visible = this.rbTrapezoid.Checked;
			this.TextChange();
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtRadius.Visible = this.rbCircle.Checked;
	        this.lblRadius.Visible = this.rbCircle.Checked;
			this.TextChange();
        }

		private void TextChange()
		{
			foreach (var tb in this.Controls.OfType<TextBox>())
			{
				tb.Text = "0";
			}

			this.lblArea.Text = "Area: ";
			this.lblPerimeter.Text = "Perimeter; ";

		}

		private bool IsValid(TextBox textbox, string name)
		{
			return
				this.IsDecimal(textbox, name);

		}

		private bool IsDecimal(TextBox textbox, string name)
		{
			var myDecimal = 0m;
			if (decimal.TryParse(textbox.Text, out myDecimal))
			{
				if (this.IsPositive(myDecimal))
				{
					return true;
				}
				else
				{
					MessageBox.Show("Enter a number larger than 0");
					textbox.Focus();
                    return false;
                }

			}
			else
			{
				MessageBox.Show("Must enter a valid number");
				textbox.Focus();
				return false;
			}
        }

		private bool IsPositive(decimal number)
		{
			return number >= 0;
		}

        private void kiteBtn_CheckedChanged(object sender, EventArgs e)
        {
	        this.txtSideA.Visible = this.kiteBtn.Checked;
	        this.txtSideB.Visible = this.kiteBtn.Checked;
	        this.txtHeight.Visible = this.kiteBtn.Checked;
	        this.txtRectangleWidth.Visible = this.kiteBtn.Checked;
	        this.lblSideA.Visible = this.kiteBtn.Checked;
	        this.lblSideB.Visible = this.kiteBtn.Checked;
	        this.lblHeight.Visible = this.kiteBtn.Checked;
	        this.lblWidth.Visible = this.kiteBtn.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
	        var amount = Convert.ToDecimal(this.numberTxt.Text);
	        var percentage = Convert.ToDecimal(this.percentTxt.Text);

	        var p = percentage / 100;
	        var finalAmount = amount * p;
	        this.lblResult.Text = finalAmount.ToString();

        }

    }
}
