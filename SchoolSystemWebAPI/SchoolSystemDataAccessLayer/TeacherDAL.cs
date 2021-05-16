using Microsoft.EntityFrameworkCore;
using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SchoolSystemCustomExceptionLayer;

namespace SchoolSystemDataAccessLayer
    {
    public class TeacherDAL : ITeacherDAL
        {
        private readonly SchoolDBContext _schoolDBContext;

        public TeacherDAL(SchoolDBContext schoolDBContext)
            {
            _schoolDBContext = schoolDBContext;
            }
        public async Task<bool> AddTeacher(Teacher teacher)
            {
            if(await _schoolDBContext.Teachers.FirstOrDefaultAsync(s => s.TeacherName == teacher.TeacherName) != null)
                {
                throw new DuplicateNameException("Name already exists");
                }
            else if(await _schoolDBContext.Schools.FirstOrDefaultAsync(s => s.Id == teacher.SchoolId) == null)
                {
                throw new SchoolIdNotFoundException("School Id is not found");
                }
            else if(await _schoolDBContext.Subject.FirstOrDefaultAsync(s => s.Id == teacher.SubjectId) == null)
                {
                throw new SubjectIdNotFoundException("School Id is not found");
                }
            else
                {
                try
                    {
                    int rowsAffected = 0;
                    _schoolDBContext.Teachers.Add(teacher);
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
                    throw new SqlException("Server error might have occured ,please check",ex);
                    }
                }
            }
        public async Task<bool> DeleteTeacher(int id)
            {
            try
                {
                Teacher teacherDetails = await _schoolDBContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
                int rowsAffected = 0;
                _schoolDBContext.Teachers.Remove(teacherDetails);
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
                throw new SqlException("Server error might have occured ,please check",ex);
                }
            }
        }
    }
