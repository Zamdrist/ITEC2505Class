using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccumulatedScores
{
    public class Score : IDisposable
    {
        private double _average;

        public List<int> ScoreValue { get; set; } = new List<int>();
        public int ScoreTotal { get; set; }
        public int ScoreCount { get; set; }
        public int ScoreMin { get; set; }
        public int ScoreMax { get; set; }

        public double ScoreAverage
        {
            get { return this._average; }
            set { this._average = Math.Round(value, 2); }
        }

        public bool IsIntRange(string value)
        {
            if (!int.TryParse(value, out var theValue))
            {
                MessageBox.Show("Not a valid integer", "Accumulated Scores");
                return false;
            }
            else if (!(theValue >= 0 && theValue <= 100))

            {
                MessageBox.Show("Score must be between 0 and 100", "Accumulated Scores");
                return false;
            }

            return true;
        }

        public void Dispose()
        {
            this.ScoreValue.Clear();
            this.ScoreAverage = default(double);
            this.ScoreCount = default(int);
            this.ScoreTotal = default(int);

        }
    }
}
