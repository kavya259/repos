using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCourseManagementEntities
    {
    public class Course
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId
            {
            get; set;
            }
        public string CourseName
            {
            get; set;
            }
        public string Qualification
            {
            get; set;
            }
        public string InstituteName
            {
            get; set;
            }
        }
    }
