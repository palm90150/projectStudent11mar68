using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Person
    {
        public string FullName { get; set; }

        public Person(string fullName)
        {
            FullName = fullName;
        }

        public virtual string GetInfo()
        {
            return $"Name: {FullName}";
        }
    }

}
