using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StudentCourseManagementDataAccessLayer;
using StudentCourseManagementEntities;


namespace StudentCourseManagentBusinessLayer
    {
    public class StudentManagementBL:IStudentManagementBL
        {
        private readonly IStudentManagementDAL _studentManagementDAL;

        public StudentManagementBL(IStudentManagementDAL studentcoursedal)
            {
            _studentManagementDAL = studentcoursedal;
            }


        public async Task<bool> AddCourseBL(Course course)
            {
            return await _studentManagementDAL.AddCourseDAL(course);

            }

        public async Task<bool> AddStudentBL(Student student)
            {
            return await _studentManagementDAL.AddStudentDAL(student);

            }

       public async Task<Course> GetAllCourseDetailsBL(int id)
            {
            return await _studentManagementDAL.GetAllCourseDetailsDAL(id);
            }


        }
    }
