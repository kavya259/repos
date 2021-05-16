using CollegeDataAccess;
using CollegeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBusinesslayer
{
    public class CollegeManagementBL:ICollegeManagementBL
    {
        public ICollegeManagementDAL collegeManagementDAL = new CollegeManagementDAL();
        //   public static ICollegeManagementBL collegeManagementBL = new CollegeManagementBL();
        public Student AddStudentDetailsBL(Student student)
            {

            return collegeManagementDAL.AddStudentDetailsDAL(student);

            }
        public List<Student> GetAllStudentDetailsBL()
            {
            return collegeManagementDAL.GetAllStudentDetailsDAL();
            }

        public Student UpdateStudentDetailsBL(Student student)
            {
            return collegeManagementDAL.UpdateStudentDetailsDAL(student);
            }
        public Branch AddBranchDetailsBL(Branch branch)
            {

            return collegeManagementDAL.AddBranchDetailsDAL(branch);
            }
        public List<Branch> GetAllBranchDetailsBL()
            {
            return collegeManagementDAL.GetAllBranchDetailsDAL();
            }

        }
    }
