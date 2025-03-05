﻿// <auto-generated />
using EF2.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF2.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF2.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Course_Duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Top_ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EF2.Models.Course_Inst", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Evaluate")
                        .HasColumnType("int");

                    b.Property<int>("Inst_Id")
                        .HasColumnType("int");

                    b.ToTable("Courses_Instructors");
                });

            modelBuilder.Entity("EF2.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("HiringDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Ins_ID")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EF2.Models.Instructor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("Dept_ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EF2.Models.Stud_Courses", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("Stud_ID")
                        .HasColumnType("int");

                    b.ToTable("Students_Courses");
                });

            modelBuilder.Entity("EF2.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_ID")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Dep_ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF2.Models.Topic", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("EF2.Models.Course", b =>
                {
                    b.HasOne("EF2.Models.Topic", "Topic")
                        .WithMany("courses")
                        .HasForeignKey("Top_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("EF2.Models.Department", b =>
                {
                    b.HasOne("EF2.Models.Instructor", "Manager")
                        .WithOne("manageddepartment")
                        .HasForeignKey("EF2.Models.Department", "Ins_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EF2.Models.Instructor", b =>
                {
                    b.HasOne("EF2.Models.Department", "departmentlocated")
                        .WithMany("instructors")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("departmentlocated");
                });

            modelBuilder.Entity("EF2.Models.Student", b =>
                {
                    b.HasOne("EF2.Models.Department", "StudentDepartment")
                        .WithMany("studentsindepartment")
                        .HasForeignKey("Dep_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentDepartment");
                });

            modelBuilder.Entity("EF2.Models.Department", b =>
                {
                    b.Navigation("instructors");

                    b.Navigation("studentsindepartment");
                });

            modelBuilder.Entity("EF2.Models.Instructor", b =>
                {
                    b.Navigation("manageddepartment");
                });

            modelBuilder.Entity("EF2.Models.Topic", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
