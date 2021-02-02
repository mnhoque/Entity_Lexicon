using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Lexicon.Models
{
    public class Assignment
    {
        [Key]
        public int Assign_Id { get; set; }

        //public int Assign_Name { get; set; }

        public int Course_Id { get; set; }

        public Course Course { get; set; }
    }
}
