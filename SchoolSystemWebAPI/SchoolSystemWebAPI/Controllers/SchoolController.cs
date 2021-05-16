using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystemBusinessLayer;
using SchoolSystemCustomExceptionLayer;
using SchoolSytemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystemWebAPI.Controllers
    {
    [Route("api/School")]
    [ApiController]
    public class SchoolController : ControllerBase
        {
        private readonly ISchoolBL _ISchoolBL;
        public SchoolController(ISchoolBL schoolBL)
            {
            _ISchoolBL = schoolBL;
            }
        [HttpPost("AddSchool")]
        public async Task<IActionResult> AddSchool(School school)
            {
            try
                {
                return Ok(await _ISchoolBL.AddSchool(school));
                }
            catch(SqlException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(DuplicateNameException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

        [HttpPatch("UpdateSchoolAddress/{id}")]

        public async Task<IActionResult> UpdateSchoolAddress(int id, string Address)
            {
            try
                {
                return Ok(await _ISchoolBL.UpdateSchoolAddress(id, Address));
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
        [HttpGet("GetListOfTeachersBySchoolId/{id}")]

        public async Task<IActionResult> GetListOfTeachersBySchoolId(int id)
            {
            try
                {
                List<Teacher> TeacherList = await _ISchoolBL.GetListOfTeachersBySchoolId(id);
                return Ok(TeacherList);
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
