using StudentCourseManagementEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCourseManagementExceptions;

namespace StudentCourseManagementDataAccessLayer
    {
    public class StudentManagementDAL:IStudentManagementDAL
        {
        private readonly StudentManagementDBContext _studentManagementDB;
        public StudentManagementDAL(StudentManagementDBContext studentDbContext)
            {
            _studentManagementDB = studentDbContext;
            }

        //Adding Courses
        public async Task<bool> AddCourseDAL(Course course)
            {
            int rowsaffected = 0;
            if(await _studentManagementDB.Courses.FirstOrDefaultAsync(s => s.CourseName == course.CourseName) != null)
                {
                throw new DuplicateNameException("Only one course is allowed ");
                }
            else
                {
                try
                    {
                    _studentManagementDB.Add(course);
                    rowsaffected = await _studentManagementDB.SaveChangesAsync();
                    if(rowsaffected == 0)
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
                    throw new SqlServerException("There must be server error", ex);
                    }
                }

            }
            //Adding students
            public async Task<bool> AddStudentDAL(Student student)
            {
            int rowsaffected = 0;
            if(await _studentManagementDB.Students.FirstOrDefaultAsync(s => s.StudentName == student.StudentName) != null)
                {
                throw new DuplicateNameException("Only one student can be allowed max for one course");
                }
            //else if(await _studentManagementDB.Students.FirstOrDefaultAsync(c=>c.CourseId==student.CourseId)!=null)
            //    {
            //    throw new DuplicateNameException("Only one student can have only course");
            //    }
            else
                {
                try
                    {
                        _studentManagementDB.Add(student);
                        rowsaffected = await _studentManagementDB.SaveChangesAsync();
                        if(rowsaffected == 0)
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
                    throw new SqlServerException("There must be server error", ex);

                    }
                }


            }


        public async Task<Course> GetAllCourseDetailsDAL(int id)
            {
            Dictionary<int, string> studentcoursedetails = new Dictionary<int, string>();
            //Student course=await _studentManagementDB.Students.FirstOrDefaultAsync(s=>s.CourseId==student.CourseId)
            int courseid;
            Course course = new Course();
            List<Student> students = await _studentManagementDB.Students.ToListAsync();
            List<Course> courses = await _studentManagementDB.Courses.ToListAsync();

            foreach(Student student1 in students)
                {
                if(student1.StudentId == id)
                    {
                    courseid = student1.CourseId;
                    foreach(Course c in courses)
                       {
                        if(c.CourseId == courseid)
                            {
                            course = c;
                            }
                        }
                    }
                }
            
            //if(await _studentManagementDB.Students.FirstOrDefaultAsync(i => i.StudentId == id) != null)
            //    {
                
            //     studentcoursedetails = await _studentManagementDB.Students.ToDictionaryAsync(s => s.StudentId, s => s.StudentName);
                //}
            return course;
            
            }


        }
    }
