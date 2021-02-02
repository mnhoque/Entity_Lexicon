using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Lexicon.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String Student_Name { get; set; }
        

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
