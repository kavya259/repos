using StudentDataAccessLayer;
using StudentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLayer
{
    public class StudentBL : IStudentBL
        {
        readonly IStudentDAL _studentBL = new StudentDAL();
        public Student AddStudentBL(Student student)
            {
            return _studentBL.AddStudentDAL(student);

            }
        public List<Student> GetAllStudentsBL()
            {
            return _studentBL.GetAllStudentsDAL();

            }

        } 
    }
