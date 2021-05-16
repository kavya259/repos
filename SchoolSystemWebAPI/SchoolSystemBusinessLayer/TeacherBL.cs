using SchoolSystemDataAccessLayer;
using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemBusinessLayer
    {
    public class TeacherBL : ITeacherBL
        {
        private readonly ITeacherDAL _iteacherDAL;
        public TeacherBL(ITeacherDAL schoolDAL)
            {
            _iteacherDAL = schoolDAL;
            }

        public async Task<bool> AddTeacher(Teacher teacher)
            {
            return await _iteacherDAL.AddTeacher(teacher);
            }
        public async Task<bool> DeleteTeacher(int id)
            {
            return await _iteacherDAL.DeleteTeacher(id);
            }

        }
    }
