using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace StudentCourseManagementEntities
    {
    
    public class Student
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId
            {
            get; set;
            }
        public string StudentName
            {
            get; set;
            }
        public string PhoneNumber
            {
            get; set;
            }
        [ForeignKey("Course")]
        public int CourseId
            {
            get; set;
            }
        //public Course Course
        //    {
        //    get; set;
        //    }
        public string Gender
            {
            get; set;
            }
        public DateTime DateOfBirth
            {
            get; set;
            }
        }
    }
