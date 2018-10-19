using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatedScores
{
    public partial class AccumulatedScoresForm : Form
    {
        private readonly Score _score = new Score();

        public AccumulatedScoresForm()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
	        try
	        {
		        if (this.IsValid())
		        {

			        this._score.ScoreValue.Add(Convert.ToInt32(this.txtScore.Text));
			        this._score.ScoreAverage = this._score.ScoreValue.Average();
			        this._score.ScoreCount = this._score.ScoreValue.Count;
			        this._score.ScoreTotal = this._score.ScoreValue.Sum();
			        this._score.ScoreMin = this._score.ScoreValue.Min();
			        this._score.ScoreMax = this._score.ScoreValue.Max();

			        this.lblScoreTotalValue.Text = this._score.ScoreTotal.ToString();
			        this.lblScoreCountValue.Text = this._score.ScoreCount.ToString();
			        this.lblScoreAverageValue.Text = this._score.ScoreAverage.ToString();
			        this.lblScoreMaxValue.Text = this._score.ScoreMax.ToString();
			        this.lblScoreMinValue.Text = this._score.ScoreMin.ToString();
			        this.txtScore.Text = string.Empty;
		        }
		        else
		        {
			        this.txtScore.Text = string.Empty;
		        }

		        this.txtScore.Focus();
            }
	        catch (Exception ex)
	        {
		        MessageBox.Show(
			        $"{ex.Message}{Environment.NewLine}{Environment.NewLine}"
			        + $"{ex.GetType()}{Environment.NewLine}{ex.StackTrace}",
			        "Exception");
            }
        }

        private bool IsValid() => this._score.IsIntRange(this.txtScore.Text);

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            this._score.Dispose();
            this.txtScore.Text = string.Empty;
            this.lblScoreTotalValue.Text = string.Empty;
            this.lblScoreAverageValue.Text = string.Empty;
            this.lblScoreCountValue.Text = string.Empty;
            this.lblScoreMaxValue.Text = string.Empty;
            this.lblScoreMinValue.Text = string.Empty;
	        this.txtScore.Focus();
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            if (this._score.ScoreValue.Count > 0)
            {
                var stringBuilder = new StringBuilder();
                this._score.ScoreValue.Sort();
                foreach (var score in this._score.ScoreValue)
                {
                    stringBuilder.Append(score.ToString());
                    stringBuilder.Append(Environment.NewLine);

                }
                MessageBox.Show(stringBuilder.ToString(), "Sorted Scores");
            }
            else
            {
                MessageBox.Show("No scores to show!", "Accumulated Scores");
            }

	        this.txtScore.Focus();
        }
    }
}
