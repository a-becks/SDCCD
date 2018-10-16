using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3_schroder
{
    public partial class Form1 : Form
    {
        private List<int> scoreList = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            scoreList.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = Int32.TryParse(txtScore.Text, out int score);
            if (!isValid || score < 0 || score > 100)
            {
                MessageBox.Show("Entry not added.  Please enter an integer between 0 and 100.", "Error");
                txtScore.Focus();
                return;
            }
            scoreList.Add(score);
            performCalculations();

            txtScore.Focus();
        }

        private void performCalculations()
        {
            int total = 0;
            int average, length;

            foreach (int score in scoreList)
            {
                total += score;
            }

            length = scoreList.Count();
            average = total / length;

            txtScoreTotal.Text = total.ToString();
            txtScoreCount.Text = length.ToString();
            txtAverage.Text = average.ToString();

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string message = "";

            scoreList.Sort();

            foreach (int score in scoreList)
            {
                message += score + "\n";
            }
            MessageBox.Show(message, "Sorted Scores");
        }
    }
}
