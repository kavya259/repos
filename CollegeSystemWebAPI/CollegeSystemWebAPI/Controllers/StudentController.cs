using CollegeSystemWebAPI.Models;
using CollegeSystemWebAPI.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeSystemWebAPI.Controllers
    {
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
        {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
            {
            _studentRepository = studentRepository;
            }
        [HttpGet]
        public IActionResult Get()
            {
            IEnumerable<Student> students = _studentRepository.GetAll();
            return Ok(students);
            }




        [HttpPost]
        public bool Post([FromBody] Student student)
            {
            if(student == null)
                {
                return false;
                }
            else
                {
                _studentRepository.Add(student);
                return true;

                }

            /*return CreatedAtRoute(
                "Get",
                new { id = student.Id }, student);*/

            }




        }
    }
