using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentCourseManagentBusinessLayer;
using StudentCourseManagementEntities;
using Microsoft.Data.SqlClient;
using StudentCourseManagementExceptions;

namespace StudentCourseManagementSystemWebApi.Controllers
    {
    [Route("api/Course")]
    [ApiController]
    public class CourseController : ControllerBase
        {
        private readonly IStudentManagementBL _studentManagementBL;
        public CourseController(IStudentManagementBL studentManagementBL)
            {
            _studentManagementBL = studentManagementBL;
            }
        [HttpPost("AddCourse")]
        public async Task<IActionResult> AddCourse(Course course)
            {
            try
                {
                return Ok(await _studentManagementBL.AddCourseBL(course));
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

        }
    }
