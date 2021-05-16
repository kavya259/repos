using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace capability.Models
    {
    public class StudentModel
        {
        public int Id
            {
            get; set;
            }
        [Required]
        public string Name
            {
            get; set;
            }
        [Required]
        public string Mobile
            {
            get; set;
            }
        [Required]
        public string Email
            {
            get; set;
            }
        [Required]
        public char Grade
            {
            get; set;
            }
        [Required]
        public int Fee
            {
            get; set;
            }

        }

    }