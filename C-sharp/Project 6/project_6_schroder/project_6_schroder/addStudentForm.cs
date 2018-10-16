using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6_schroder
{
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }

        public List<int> scoreList = new List<int>();


        private void btnAddScore_Click(object sender, EventArgs e)
        {
            Int32.TryParse(scoreTextBox.Text, out int score);
            scoreList.Add(score);
            displayScoreList();
        }

        private void displayScoreList()
        {
            string scoreDisplayStr = "";
            foreach (int score in scoreList)
            {
                scoreDisplayStr += " " + score.ToString();
            }
            scoreDisplay.Text = scoreDisplayStr;
        }

        private void btnClearScore_Click(object sender, EventArgs e)
        {
            scoreList.Clear();
            displayScoreList();
            scoreTextBox.Clear();
            scoreTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string studentName = nameTextBox.Text;
            Student newStudent = new Student(studentName, scoreList);
            this.Tag = newStudent;
        }
    }
}
