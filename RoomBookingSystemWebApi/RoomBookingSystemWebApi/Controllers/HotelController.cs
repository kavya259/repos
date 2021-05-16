using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomBookingBusinessLayer;
using RoomBookingEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using RoomBookingExceptions;

namespace RoomBookingSystemWebApi.Controllers
    {
    [Route("api/Hotel")]
    [ApiController]
    public class HotelController : ControllerBase
        {
        private readonly IRoomBookingBL _roomBookingBL;
        public HotelController(IRoomBookingBL roomBookingBL)
            {
            _roomBookingBL = roomBookingBL;
            }
        [HttpPost("AddHotel")]
        public async Task<IActionResult> AddHotel(Hotel hotel)
            {
            try
                {
                return Ok(await _roomBookingBL.AddHotelBl(hotel));
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

        [HttpPost("GetHotel/{name}")]
        public async Task<IActionResult> GetHotel(string name)
            {
            try
                {
                return Ok(await _roomBookingBL.GetHotelBL(name));
                }
            catch(NameNotFoundException ex)
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
