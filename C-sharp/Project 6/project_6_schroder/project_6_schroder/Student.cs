using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6_schroder
{
    public class Student
    {
        private string name;
        private List<int> scoreList = new List<int>();

        public Student(string name, List<int> someScoreList)
        {
            this.name = name;
            foreach (int score in someScoreList){
                this.scoreList.Add(score);
            }
        }

        public string Name { get { return this.name; } }

        public List<int> ScoreList { get { return this.scoreList; } }

        public void addScore(int score)
        {
            this.scoreList.Add(score);
        }

        public void updateScore(int scoreToRemove, int scoreToAdd)
        {
            int index = this.scoreList.FindIndex(score => score == scoreToRemove);
            if (index != -1)
            {
                this.scoreList[index] = scoreToAdd;
            }
        }

        public void removeScore(int score)
        {
            this.scoreList.Remove(score);
        }

        public void clearScoreList()
        {
            this.scoreList.Clear();
        }

        public override string ToString()
        {
            string studentString = name;
            foreach (int score in scoreList)
            {
                studentString += "|" + score.ToString();
            }
            return studentString;
        }
    }
}
