using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeSystemWebAPI.Models.Repository
    {
    public class StudentManager : IStudentRepository
        {


        public readonly StudentContext _studentContext;
        public StudentManager(StudentContext context)
            {
            _studentContext = context;
            }
        public void Add(Student student)
            {
            _studentContext.student.Add(student);
            _studentContext.SaveChanges();
            }

        public IEnumerable<Student> GetAll()
            {
            return _studentContext.student.ToList();
            }
        }
    }
