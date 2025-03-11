using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Advisor : Person
    {
        private List<Student> students = new List<Student>();

        public Advisor(string fullName) : base(fullName) { }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public string GetStudentList()
        {
            if (students.Count == 0) return "No students assigned.";
            return $"Students under {FullName}:\n" + string.Join("\n", students.Select(s => s.FullName));
        }
    }

}
