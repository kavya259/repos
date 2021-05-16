using CollegeManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementBusinesslayer
    {
    public interface ICollegeManagementBL 
        {
        Student AddStudentDetailsBL(Student student);
        List<Student> GetAllStudentDetailsBL();
        Student UpdateStudentDetailsBL(Student student);
        Branch AddBranchDetailsBL(Branch branch);
        List<Branch> GetAllBranchDetailsBL();

        }
    }
