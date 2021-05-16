using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurentManagementSystem.MVCWebApplication.Models
    {
    public class StaffModel
        {
        public int StaffId
            {
            get; set;
            }
        [Required]
        public string StaffName
            {
            get; set;
            }
        public string StaffGender
            {
            get; set;
            }
        public string StaffShift
            {
            get; set;
            }

        }
    }