using SchoolSystemDataAccessLayer;
using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemBusinessLayer
    {
    public class SchoolBL : ISchoolBL
        {
        private readonly ISchoolDAL _iSchoolDAL;
        public SchoolBL(ISchoolDAL schoolDAL)
            {
            _iSchoolDAL = schoolDAL;
            }

        public async Task<bool> AddSchool(School school)
            {
            return await _iSchoolDAL.AddSchool(school);
            }

        public async Task<List<Teacher>> GetListOfTeachersBySchoolId(int id)
            {
            return await _iSchoolDAL.GetListOfTeachersBySchoolId(id);

            }

        public async Task<bool> UpdateSchoolAddress(int id, string address)
            {
            return await _iSchoolDAL.UpdateSchoolAddress(id, address);

            }

        }
    }
