using StudentCourseManagementEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentCourseManagentBusinessLayer
    {
    public interface IStudentManagementBL
        {
        Task<bool> AddCourseBL(Course course);
        Task<bool> AddStudentBL(Student student);
        Task<Course> GetAllCourseDetailsBL(int id);
        }
    }
