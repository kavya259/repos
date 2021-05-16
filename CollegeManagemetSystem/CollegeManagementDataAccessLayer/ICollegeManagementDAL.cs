using CollegeManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementDataAccessLayer
    {
    public interface ICollegeManagementDAL
        {
        Student AddStudentDetailsDAL(Student student);

        List<Student> GetAllStudentDetailsDAL();
        Student UpdateStudentDetailsDAL(Student student);
        Branch AddBranchDetailsDAL(Branch branch);
        List<Branch> GetAllBranchDetailsDAL();

        }
    
    }
