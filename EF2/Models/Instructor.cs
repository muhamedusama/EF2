using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }

        public decimal Bonus { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public decimal HourRate { get; set; }
        [Required]
        public int Dept_ID { get; set; }
        public Department departmentlocated { get; set; }
        public Department? manageddepartment { get; set; }
    }
}
