using System;
using System.Collections.Generic;
using System.Text;
using SchoolSytemEntities;
using SchoolSystemCustomExceptionLayer;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SchoolSystemDataAccessLayer
    {
    public class SchoolDAL : ISchoolDAL
        {

        private readonly SchoolDBContext _schoolDBContext;

        public SchoolDAL(SchoolDBContext schoolDBContext)
            {
            _schoolDBContext = schoolDBContext;
            }
        public async Task<bool> AddSchool(School school)
            {
            int rowsAffected = 0;

            if(await _schoolDBContext.Schools.FirstOrDefaultAsync(s => s.SchoolName == school.SchoolName) != null)
                {
                throw new DuplicateNameException("Name already exists");
                }
            else
                {
                try
                    {
                    _schoolDBContext.Add(school);
                    rowsAffected = await _schoolDBContext.SaveChangesAsync();
                    if(rowsAffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("server error might have occured,please check", ex);
                    }
                }
            }

        public async Task<List<Teacher>> GetListOfTeachersBySchoolId(int id)
            {
            if(await _schoolDBContext.Schools.FirstOrDefaultAsync(s => s.Id == id) != null)
                {
                throw new SchoolIdNotFoundException("Id not found");
                }
            else
                {
                try
                    {
                    List<Teacher> TeachersList = _schoolDBContext.Teachers.Where(s => s.SchoolId == id).ToList<Teacher>();
                    return TeachersList;
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("server error occured!", ex);
                    }
                }

            }

        public async Task<bool> UpdateSchoolAddress(int id, string address)
            {
            if(await _schoolDBContext.Schools.FirstOrDefaultAsync(s => s.Id == id) == null)
                {
                throw new SchoolIdNotFoundException("Id is not found");
                }
            else
                {
                try
                    {
                    int rowsAffected = 0;
                    School schoolTemp = await _schoolDBContext.Schools.FirstOrDefaultAsync(t => t.Id == id);
                    schoolTemp.SchoolAddress = address;
                    rowsAffected = await _schoolDBContext.SaveChangesAsync();
                    if(rowsAffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("server error occured" + ex.InnerException, ex);
                    }
                }
            }

        }
    }
