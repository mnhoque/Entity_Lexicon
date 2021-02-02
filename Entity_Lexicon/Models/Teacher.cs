using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Lexicon.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Teacher_Name { get; set; }
        public Course Course { get; set; }
        
    }
}
