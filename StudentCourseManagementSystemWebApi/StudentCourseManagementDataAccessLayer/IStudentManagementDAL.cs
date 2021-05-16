using StudentCourseManagementEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseManagementDataAccessLayer
    {
    public interface IStudentManagementDAL
        {
         Task<bool> AddCourseDAL(Course course);
        Task<bool> AddStudentDAL(Student student);
        Task<Course> GetAllCourseDetailsDAL(int id);
        }
    }
