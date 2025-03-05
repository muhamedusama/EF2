using EF2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF2.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Courses> Students_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course_Inst> Courses_Instructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = itiEF; Trusted_Connection = true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().HasNoKey();
            modelBuilder.Entity<Stud_Courses>().HasNoKey();

            modelBuilder.Entity<Student>().HasOne(s => s.StudentDepartment)
                .WithMany(d => d.studentsindepartment)
                .HasForeignKey(s=>s.Dep_ID);

            modelBuilder.Entity<Course>().HasOne(c => c.Topic)
                .WithMany(c=>c.courses)
                .HasForeignKey(c=>c.Top_ID);

            modelBuilder.Entity<Instructor>().HasOne(i => i.departmentlocated)
                .WithMany(e => e.instructors)
                .HasForeignKey(d => d.Dept_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>().HasOne(d => d.Manager)
                .WithOne(m => m.manageddepartment)
                .HasForeignKey<Department>(m => m.Ins_ID);
        }
    }
}
