using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Lexicon.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Teacher_Name { get; set; }
        public Course Course { get; set; }
        //public int Course_Id { get; set; }
    }
}
