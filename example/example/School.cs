using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
    {
    public abstract class School:ISchool
        {
        public int SchoolCode
            {
            get; set;
            }
        public string SchoolName
            {
            get; set;
            }

        public abstract string GetDetails();

        public int GetSchoolCode()
            {
            return this.SchoolCode;
            }
            
        }
    }
