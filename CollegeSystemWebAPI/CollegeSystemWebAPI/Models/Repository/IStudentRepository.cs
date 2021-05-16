using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeSystemWebAPI.Models.Repository
    {
    
        public interface IStudentRepository
            {
            IEnumerable<Student> GetAll();
            void Add(Student entity);
        }
        }
    
