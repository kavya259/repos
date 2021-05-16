using System;
using Microsoft.EntityFrameworkCore;
using StudentCourseManagementEntities;
namespace StudentCourseManagementDataAccessLayer
    {
    public class StudentManagementDBContext : DbContext
        {
        public StudentManagementDBContext()

            {
            }
        public StudentManagementDBContext(DbContextOptions<StudentManagementDBContext> options):base(options)
            {
            }
        public DbSet<Student> Students
            {
            get;set;
            }
        public DbSet<Course> Courses
            {
            get; set;
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TEJJIDI;Initial Catalog=StudentCourseDB;Integrated Security=True");
            }

        protected override void OnModelCreating(ModelBuilder builder)
            {
            base.OnModelCreating(builder);
            }

        }
    }
