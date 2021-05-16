using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
    {
    public class Staff:School
        {
        public int StaffId
            {
            get; set;
            }
        public string StaffName
            {
            get; set;
            }
        public string subject
            {
            get; set;
            }
        public override string GetDetails()
            {
            return "StudentName:" + this.StaffName + "subject:" + this.subject + "SchoolName:" + this.SchoolName;
            }
        }
    }
