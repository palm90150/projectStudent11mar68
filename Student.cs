using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }
        public Advisor Advisor { get; set; }
        public double Grade { get; set; }

        public Student(string fullName, string studentID, string major, Advisor advisor, double grade)
            : base(fullName)
        {
            StudentID = studentID;
            Major = major;
            Advisor = advisor;
            Grade = grade;
            advisor.AddStudent(this); // เชื่อมโยงนักศึกษากับที่ปรึกษา
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, ID: {StudentID}, Major: {Major}, Grade: {Grade}, Advisor: {Advisor.FullName}";
        }
    }
}
