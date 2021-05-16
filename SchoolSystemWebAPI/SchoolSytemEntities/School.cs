using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSytemEntities
    {
   public class School
        {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]

        public int Id
            {
            get; set;
            }
        [Column(TypeName = "text")]
        [Required]
        public string SchoolName
            {
            get; set;
            }
        [Column(TypeName = "text")]
        [Required]
        public string SchoolAddress
            {
            get; set;
            }
        public List<Teacher> Teachers
            {
            get; set;
            }



        }
    }
