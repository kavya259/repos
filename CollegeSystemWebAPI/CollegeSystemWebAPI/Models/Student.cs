using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeSystemWebAPI.Models
    {
    public class Student
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StudentId
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        
        public DateTime DateOfBirth
            {
            get; set;
            }
        public string Address
            {
            get; set;
            }
        public string Branch
            {
            get;set;
            }

        }
    }
