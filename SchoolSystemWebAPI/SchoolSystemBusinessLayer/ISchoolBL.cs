using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolSystemBusinessLayer
    {
    public interface ISchoolBL
        {
        public Task<bool> AddSchool(School school);
        public Task<bool> UpdateSchoolAddress(int id, string address);
        public Task<List<Teacher>> GetListOfTeachersBySchoolId(int id);

        }
    }
    
