using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemBusinessLayer
    {

    public interface ITeacherBL
        {
        public Task<bool> AddTeacher(Teacher teacher);
        public Task<bool> DeleteTeacher(int id);


        }
    }
