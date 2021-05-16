using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeManagemetSystem.WebApplication.Models
    {
    public class BranchModel
        {
        [Required]

        public int BranchId
            {
            get; set;
            }
        [Required]

        public string BranchName
            {
            get; set;
            }

        }
    }