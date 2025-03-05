using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Courses_Instructors")]
    internal class Course_Inst
    {
        [Required]
        public int Inst_Id { get; set; }
        [Required]
        public int Course_Id { get; set; }
        [Required]
        public int Evaluate { get; set; }
    }
}
