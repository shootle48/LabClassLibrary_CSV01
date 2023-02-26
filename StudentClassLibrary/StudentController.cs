using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentClassLibrary
{
    public class StudentController
    {
        List<Student> listStudent = new List<Student>();

        public void addStudent2List(string id, string name) { 
            Student newStudent = new Student(id, name);
            listStudent.Add(newStudent);
        }
        public string displayData(string dataShow) {
            string DataShow = dataShow;
            foreach(Student student in listStudent)
            {
                 string display = student.displayInfo();
                 DataShow += display;
            }
            return DataShow;
        }
        public void saveFile(string save) {
            string savedData = save;
            File.WriteAllText("d:/text.csv",savedData);
        }
        public void openFile() {
            StreamReader reader = new StreamReader("d:/text.csv");
            string data = reader.ReadToEnd();
            string[] splittedData = data.Split(',');
            foreach (string currentData in splittedData)
            {
                if(currentData.Trim() != "")
                {
                    listStudent.Add(currentData);
                }
            }
        }
    }
}
