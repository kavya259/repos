using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeSystemWebAPI.Models.Repository
    {
    public class StudentContext : DbContext
        {
        public StudentContext(DbContextOptions options) : base(options)
            {

            }

        public DbSet<Student> student
            {
            get; set;
            }


        }
    }