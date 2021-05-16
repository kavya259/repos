using StudentEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataAccessLayer
    {
    public interface IStudentDAL
        {
        Task<bool> AddStudent(Student student);
        Task<List<Student>> GetStudents();
        }
    }
