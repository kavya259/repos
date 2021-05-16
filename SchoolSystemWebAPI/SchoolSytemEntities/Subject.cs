using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSytemEntities
    {
    public class Subject
        {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        [Required]
        public int Id
            {
            get; set;
            }
        [Column(TypeName = "text")]
        [Required]
        public string SubjectName
            {
            get; set;
            }

        public List<Teacher> Teachers
            {
            get; set;
            }

        }
    }
