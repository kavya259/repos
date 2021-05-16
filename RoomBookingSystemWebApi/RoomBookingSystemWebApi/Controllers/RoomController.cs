using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomBookingBusinessLayer;
using RoomBookingEntities;
using RoomBookingExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBookingSystemWebApi.Controllers
    {
    [Route("api/Room")]
    [ApiController]
    public class RoomController : ControllerBase
        {
        private readonly IRoomBookingBL _roomBookingBL;
        public RoomController(IRoomBookingBL roomBookingBL)
            {
            _roomBookingBL = roomBookingBL;
            }
        [HttpPost("AddRoom")]
        public async Task<IActionResult> AddRoom(Room room)
            {
            try
                {
                return Ok(await _roomBookingBL.AddRoomBl(room));
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


        }
    }
