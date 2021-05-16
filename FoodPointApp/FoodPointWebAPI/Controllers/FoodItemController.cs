using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodPointEntities;
using FoodPointExceptionLayer;
using FoodPointBusinessLayer;



namespace FoodPointWebAPI.Controllers
    {
    [Route("api/FoodItem")]
    [ApiController]
    public class FoodItemController : ControllerBase
        {
        private readonly IFoodPointBL _FoodPoint;
        public FoodItemController(IFoodPointBL FoodPointBL)
            {
            _FoodPoint = FoodPointBL;
            }
        [HttpPost("AddFoodItem")]
        public async Task<IActionResult> AddFoodItem(FoodItem foodItem)
            {
            try
                {
                return Ok(await _FoodPoint.AddFoodItemBL(foodItem));
                }
            catch(SqlException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(DuplicateFoodItemNameException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }
            }
        [HttpGet("GetAllFoodItems")]
        public async Task<IActionResult> GetAllFoodItems()
            {
            try
                {
                List<FoodItem> foodItemsList = await _FoodPoint.GetAllFoodItemsBL();
                return Ok(foodItemsList);
                }
            catch(Exception ex)
                {
                return BadRequest(ex.Message);
                }

            }
        [HttpPatch("UpdateItem/{id}")]
        public async Task<IActionResult> UpdateItem(int id,FoodItem foodItem)
            {
            try
                {
                return Ok(await _FoodPoint.UpdateItemBL(id,foodItem));
                }
            catch(SqlException ex)
                {
                return BadRequest(ex.Message);
                }
            catch(DuplicateFoodItemNameException ex)
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