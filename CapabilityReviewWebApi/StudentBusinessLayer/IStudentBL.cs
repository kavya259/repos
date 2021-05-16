using StudentEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLayer
    {
    public interface IStudentBL
        {
        Task<bool> AddStudentsBL(Student student);
        Task<List<Student>> GetStudentsBL();
        }
    }
