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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentList studentList = new StudentList();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form addStudentForm = new addStudentForm();
            DialogResult selectedBtn = addStudentForm.ShowDialog();
            if (selectedBtn == DialogResult.OK)
            {
                studentList.Add((Student)addStudentForm.Tag);
                displayStudentList();
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            Student s = findSelectedStudent();
            if (s == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            updateStudentForm updateStudentForm = new updateStudentForm();
            updateStudentForm.loadStudent(s);
            DialogResult selectedBtn = updateStudentForm.ShowDialog();
            displayStudentList();
        }

        private Student findSelectedStudent()
        {
            if (studentListBox.SelectedIndex == -1)
            {
                return null;
            }

            return (Student)studentListBox.SelectedItem;
        }

        private void displayStudentList()
        {
            studentListBox.Items.Clear();

            foreach (Student s in studentList)
            {
                studentListBox.Items.Add(s);
            }
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = findSelectedStudent();
            if (s == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            List<int> scoreList = s.ScoreList;
            int scoreTotal = 0;
            int scoreCount = 0;
            int average;

            foreach (int score in scoreList)
            {
                scoreTotal += score;
                scoreCount += 1;
            }

            if (scoreCount == 0)
            {
                average = 0;
            }
            else
            {
                average = scoreTotal / scoreCount;
            }

            tbScoreTotal.Text = scoreTotal.ToString();
            tbScoreCount.Text = scoreCount.ToString();
            tbAverage.Text = average.ToString();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Student s = findSelectedStudent();
            if (s == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            studentList.Remove(s);
            displayStudentList();
        }
    }
}
