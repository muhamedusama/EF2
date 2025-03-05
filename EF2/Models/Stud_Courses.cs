using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Students_Courses")]
    internal class Stud_Courses
    {
        [Required]
        public int Stud_ID { get; set; }
        [Required]
        public int Course_ID { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
