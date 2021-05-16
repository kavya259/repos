using System;
using System.Collections.Generic;
using System.Text;
using SchoolSytemEntities;
using SchoolSystemCustomExceptionLayer;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystemDataAccessLayer
    {
    public class SchoolDBContext : DbContext
        {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
            {

            }
        public DbSet<School> Schools
            {
            get; set;
            }
        public DbSet<Subject> Subject
            {
            get; set;
            }
        public DbSet<Teacher> Teachers
            {
            get; set;
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Subject>().HasData(new Subject
                {
                Id = 1,
                SubjectName = "C#",
                },
                new Subject
                    {
                    Id = 2,
                    SubjectName = "java",
                    }, new Subject
                        {
                        Id = 3,
                        SubjectName = "DOTNET",
                        }, new Subject
                            {
                            Id = 4,
                            SubjectName = "Python",
                            }, new Subject
                                {
                                Id = 5,
                                SubjectName = "C",
                                }, new Subject
                                    {
                                    Id = 6,
                                    SubjectName = "Azure",
                                    }
            );
            }

        }
    }
