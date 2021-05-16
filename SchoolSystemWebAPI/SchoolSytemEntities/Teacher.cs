using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSytemEntities
    {
    public class Teacher
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId
            {
            get; set;
            }
        [Column(TypeName ="text")]
        public string TeacherName
            {
            get; set;
            }

        [Column(TypeName = "int")]

        public int SubjectId
            {
            get; set;
            }
        [ForeignKey("SubjectId")]
        [Required]
        public Subject Subject
            {
            get; set;
            }
        [Column(TypeName = "int")]
        public int SchoolId
            {
            get; set;
            }
        [ForeignKey("SchoolId")]
        [Required]

        public School School
            {
            get; set;
            }


        }
    }
