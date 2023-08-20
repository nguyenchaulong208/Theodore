using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116_Editing_And_Removing_Entries_in_a_Dictionairy
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        //Contructor
        public Student(int id, string name, float gpa)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
