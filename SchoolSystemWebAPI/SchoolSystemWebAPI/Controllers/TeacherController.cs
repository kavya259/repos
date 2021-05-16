using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystemBusinessLayer;
using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolSystemCustomExceptionLayer;

namespace SchoolSystemWebAPI.Controllers
    {
    [Route("api/Teacher")]
    [ApiController]
    public class TeacherController : ControllerBase
        {
        private readonly ITeacherBL _ITeacherBL;
        public TeacherController(ITeacherBL teacherBL)
            {
            _ITeacherBL = teacherBL;
            }
        [HttpPost("AddTeacher")]
        public async Task<IActionResult> AddTeacher(Teacher teacher)
            {
            try
                {
                return Ok(await _ITeacherBL.AddTeacher(teacher));
                }
            catch(SubjectIdNotFoundException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(SchoolIdNotFoundException ex)
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

        [HttpDelete("DeleteTeacher/{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
            {
            try
                {
                return Ok(await _ITeacherBL.DeleteTeacher(id));
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







    
