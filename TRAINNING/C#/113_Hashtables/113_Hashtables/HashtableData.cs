using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113_Hashtables
{
    public class HashtableData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        //Contructor
        public HashtableData(int id, string name, float gpa)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
