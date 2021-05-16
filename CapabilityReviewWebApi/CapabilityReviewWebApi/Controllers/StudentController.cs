using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentBusinessLayer;
using StudentEntities;

namespace CapabilityReviewWebApi.Controllers
    {
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
        {
        private readonly IStudentBL _studentBL;
        public StudentController(IStudentBL studentBL)
            {
            _studentBL = studentBL;
            }
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(Student student)
            {
            try
                {
                return Ok(await _studentBL.AddStudentsBL(student));
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        [HttpGet(" GetStudentsExportToExcel")]
        public async Task<IActionResult> GetStudentsExportToExcel()
            {
            try
                {
                List<Student> students = await _studentBL.GetStudentsBL();
                return Ok(students);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }


        }
    }
