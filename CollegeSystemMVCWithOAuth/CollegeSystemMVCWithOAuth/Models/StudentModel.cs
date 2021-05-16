using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeSystemMVCWithOAuth.Models
    {
    public class StudentModel
        {
        public int Id
            {
            get; set;
            }
        public string FirstName
            {
            get; set;
            }
        public string LastName
            {
            get; set;
            }
        public string Email
            {
            get; set;
            }
        public string Gender
            {
            get; set;
            }
        public int Branchid
            {
            get; set;
            }

        public string DateOfBirth
            {
            get; set;
            }
        public int Age
            {
            get; set;
            }





        }
    }