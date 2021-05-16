using StudentInfo.Entities;
using System;
using StudentInfo.DataAccessLayer;
using StudentInfo.CustomExceptionLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.BusinessLayer
{
    public class StudentBL
        {
        public static void AddBranchBL(Branch branch)
            {
            StudentDAL.AddBranchDAL(branch);
            }

        
        public static void DisplayBranchesBL()
            {
            StudentDAL.DisplayBranchesDAL();
            }

        public static void AddStudentBL(Student student)
            {
            StudentDAL.AddStudentDAL(student);
            }

        public static void DisplayBranchesOfMaximumStudentsBL()
            {
            StudentDAL.DisplayBranchesOfMaximumStudentsDAL();
            }
        }
    }
