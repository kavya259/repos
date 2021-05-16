using StudentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataAccess
    {
    public interface IStudentDAL
        {
        Student AddStudentDAL(Student student);
        List<Student> GetAllStudentsDAL();
        }
    }
