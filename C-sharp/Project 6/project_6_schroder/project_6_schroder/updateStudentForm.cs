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
    public partial class updateStudentForm : Form
    {
        public updateStudentForm()
        {
            InitializeComponent();
        }

        Student s;

        public void loadStudent(Student s)
        {
            this.s = s;
            nameTextBox.Text = s.Name;
            displayScoreList();
        }

        private void displayScoreList() {
            scoresListBox.Items.Clear();

            List<int> scoreList = s.ScoreList;
            foreach (int score in scoreList)
            {
                scoresListBox.Items.Add(score);
            }
        }

        private int findSelectedScore()
        {
            return (scoresListBox.SelectedIndex);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = findSelectedScore();
            if (index == -1)
            {
                MessageBox.Show("Please select a score to update");
                return;
            }
            updateScoresForm updateScoresForm = new updateScoresForm();
            updateScoresForm.initializeScore(scoresListBox.Items[index].ToString());
            DialogResult selectedBtn = updateScoresForm.ShowDialog();
            if (selectedBtn == DialogResult.OK)
            {
                int oldScore = Convert.ToInt32(scoresListBox.Items[index]);
                int newScore = Convert.ToInt32(updateScoresForm.Tag);
                s.updateScore(oldScore, newScore);
                displayScoreList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = findSelectedScore();
            if (index == -1)
            {
                MessageBox.Show("Please select a score to remove");
                return;
            }
            s.removeScore((int)scoresListBox.Items[index]);
            displayScoreList();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            Form addScore = new AddScoreToUpdateForm();
            DialogResult selectedBtn = addScore.ShowDialog();
            if (selectedBtn == DialogResult.OK)
            {
                s.addScore(Convert.ToInt32(addScore.Tag));
                displayScoreList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            s.clearScoreList();
            displayScoreList();
        }
    }
}
