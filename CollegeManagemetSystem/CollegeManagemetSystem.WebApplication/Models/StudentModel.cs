using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollegeManagementEntities;
using CollegeManagementBusinesslayer;
using CollegeManagementExceptions;
using System.ComponentModel.DataAnnotations;
using DocuSign.eSign.Model;

namespace CollegeManagemetSystem.WebApplication.Models
    {
    public class StudentModel
        {
        [Required]
        [Display(Name = "Student Name")]

        public int ID
            {
            get; set;
            }
        [Required]
        [Display(Name = "First Name")]

        public string FirstName
            {
            get; set;
            }
        [Required]
        [Display(Name = "Last Name")]

        public string LastName
            {
            get; set;
            }
        [Required]
        [DataType(DataType.EmailAddress)]

        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter valid email")]
        public string Email
            {
            get; set;
            }
        [Required]

        public string Gender
            {
            get; set;
            }
        [Required]

        public int Branchid
            {
            get; set;
            }
        [Required]

        public string DateOfBirth
            {
            get
                {
                DateTime Date = DateTime.Now;
                return Date.ToString("yyyy-MM-dd");
                ;
                }

            set
                {
                }

            }
        public int Age
            {
            get; set;
            }


        }
    }