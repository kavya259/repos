using Microsoft.EntityFrameworkCore;
using StudentEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDataAccessLayer
    {
    public class StudentDBContext:DbContext
        {
        public StudentDBContext()
            {
            }
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
            {
            }
        public DbSet<Student> Students
            {
            get;set;
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
            {
            optionsbuilder.UseSqlServer("data source=desktop-tejjidi;initial catalog=studentwebapidb;integrated security=true");
            }
        protected override void OnModelCreating(ModelBuilder builder)
            {
            base.OnModelCreating(builder);
            }
        }
    }
