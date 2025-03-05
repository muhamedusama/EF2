using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        public String LName { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Dep_ID { get; set; }
        public Department StudentDepartment { get; set; }
    }
}
