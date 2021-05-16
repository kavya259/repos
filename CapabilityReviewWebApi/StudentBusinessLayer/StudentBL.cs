using StudentDataAccessLayer;
using StudentEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentBusinessLayer
    {
    public class StudentBL:IStudentBL
        {
        private readonly IStudentDAL _studentDAL;
        public StudentBL(IStudentDAL studentdal)
            {
            _studentDAL = studentdal;
            }
        public async Task<bool> AddStudentsBL(Student student)
            {
            return await _studentDAL.AddStudent(student);
            }
        public async Task<List<Student>> GetStudentsBL()
            {
            return await _studentDAL.GetStudents();
            }
        }
    }
