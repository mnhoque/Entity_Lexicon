using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_Lexicon.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name ="Course name")]
        public String CourseName { get; set; }

        public string description { get; set; }

        public Teacher Teacher { get; set; }
        public int Teacher_Id { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }

        

        public List<Assignment> Assignments { get; set; }
    }
}