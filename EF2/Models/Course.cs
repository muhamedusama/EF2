using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Courses")]
    internal class Course
    {
        [Key]
        public int id { get; set; }

        [Column("Course_Duration", TypeName = "int")]
        [Required]
        public int Duration { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Top_ID { get; set; }

        public Topic Topic { get; set; }

    }
}
