using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_7_schroder
{
    class StudentDB
    {
        private string dir;
        private string file;
        public StudentDB()
        {
            dir = "C:\\C#.NET\\Files";
            file = dir + "\\" + "StudentScores.txt";
            initializeFile();

        }

        private void initializeFile()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (!File.Exists(file))
            {
                FileStream fs = File.Create(file);
                fs.Close();
            }
        }

        public void writeFile(StudentList someList) {
            StreamWriter textWriter = new StreamWriter(new FileStream(file, FileMode.Create, FileAccess.Write));
            foreach (Student s in someList)
            {
                textWriter.WriteLine(s.ToString());
            }
            textWriter.Close();
        }

        public StudentList readFile()
        {
            StudentList studentList = new StudentList();
            StreamReader fileReader = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.Read));
            while (fileReader.Peek() != -1)
            {
                string line = fileReader.ReadLine();
                string[] infoArray = line.Split('|');
                string name = infoArray[0];

                List<int> gradeList = new List<int>();
                for (int i = 1; i < infoArray.Length; i++)
                {
                    gradeList.Add(Convert.ToInt32(infoArray[i]));
                }

                studentList.Add(new Student(name, gradeList));
            }
            fileReader.Close();
            return studentList;
        }
    }
}
