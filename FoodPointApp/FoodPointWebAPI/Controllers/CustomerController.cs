using FoodPointBusinessLayer;
using FoodPointEntities;
using FoodPointExceptionLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPointWebAPI.Controllers
    {
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
        {
        private readonly IFoodPointBL _FoodPoint;
        public CustomerController(IFoodPointBL FoodPointBL)
            {
            _FoodPoint = FoodPointBL;
            }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(Customer customer)
            {
            try
                {
                return Ok(await _FoodPoint.AddCustomerBL(customer));
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
        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
            {
            try
                {
                bool deleted = await _FoodPoint.DeleteCustomerBL(id);
                return Ok(deleted);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }

            [HttpGet("GetCustomer/{id}")]
            public async Task<IActionResult> GetCustomer(int id)
                {
                try
                    {
                    Customer customer = await _FoodPoint.GetCustomerBL(id);
                    return Ok(customer);
                    }
                catch(Exception ex)
                    {
                    return BadRequest(ex.Message);
                    }





                }
            }
    }
