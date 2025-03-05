using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Models
{
    [Table("Departments")]
    internal class Department
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }
        public int Ins_ID { get; set; }
      
        public String HiringDate { get; set; }
        public ICollection <Student>? studentsindepartment { get; set; }

        public ICollection<Instructor>? instructors { get; set; }

        public  Instructor Manager { get; set; }
    }
}
