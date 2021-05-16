using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem
    {
    class College
        {
        
            public College()
                {
                }
            public String CollegeId
                {
                get; set;
                }
            public String CollegeName
                {
                get; set;
                }
            public String Location
                {
                get; set;
                }
            public double CutOffPercentage
                {
                get; set;
                }
            public int NumberOfSeats
                {
                get; set;
                }





            }
    class Student
        {

        public Student()
            {
            }
        public string StudentId
            {
            get; set;
            }
        public string StudentName
            {
            get; set;
            }
        public College College
            {
            get; set;
            }
        public double PercentageObtained
            {
            get; set;
            }


        }




    }

