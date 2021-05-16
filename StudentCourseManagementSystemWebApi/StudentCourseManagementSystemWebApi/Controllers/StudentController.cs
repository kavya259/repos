using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StudentCourseManagementEntities;
using StudentCourseManagementExceptions;
using StudentCourseManagentBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseManagementSystemWebApi.Controllers
    {
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
        {
        private readonly IStudentManagementBL _studentManagementBL;
        public StudentController(IStudentManagementBL studentManagementBL)
            {
            _studentManagementBL = studentManagementBL;
            }
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(Student student)
            {
            try
                {
                return Ok(await _studentManagementBL.AddStudentBL(student));
                    
                }
            catch(SqlServerException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(DuplicateNameException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(SqlException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);

                }
            }
        [HttpGet("GetAllCourseDetails/{id}")]
        public async Task<IActionResult> GetAllCourseDetails(int id)
            {
            try
                {
                Course coursedetails=await _studentManagementBL.GetAllCourseDetailsBL(id);
                return Ok(coursedetails);

                }
            catch(SqlServerException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(SqlException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);

                }
            }

        }
    }
