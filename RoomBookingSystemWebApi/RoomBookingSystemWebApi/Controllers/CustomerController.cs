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
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
        {
        private readonly IRoomBookingBL _roomBookingBL;
        public CustomerController(IRoomBookingBL roomBookingBL)
            {
            _roomBookingBL = roomBookingBL;
            }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(Customer customer)
            {
            try
                {
                return Ok(await _roomBookingBL.AddCustomerBl(customer));
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

        [HttpPost("UpdateCustomer/{id}")]
        public async Task<IActionResult> UpdateCustomer(int id,Customer customer)
            {
            try
                {
                return Ok(await _roomBookingBL.UpdateCustomerBL(id,customer));
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
