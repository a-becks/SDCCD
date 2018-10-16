using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_7_schroder
{
    class StudentList : List<Student>
    {
        public void Update(Student studentName, int scoreToRemove, int scoreToAdd)
        {
            studentName.updateScore(scoreToRemove, scoreToAdd);
        }
    }
}
