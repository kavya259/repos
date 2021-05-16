using StudentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBusinessLayer
    {
    public  interface IStudentBL
        {
        Student AddStudentBL(Student student);
        List<Student> GetAllStudentsBL();
        }
    }
