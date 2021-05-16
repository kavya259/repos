using FoodPointDataAccessLayer;
using FoodPointEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodPointBusinessLayer
    {
    public class FoodPointBL:IFoodPointBL
        {
        private readonly IFoodPointDAL _foodPointDAL;
        public FoodPointBL(IFoodPointDAL foodpoint)
            {
            _foodPointDAL = foodpoint;
            }
        public async Task<bool> AddFoodItemBL(FoodItem foodItem)
            {
            return await _foodPointDAL.AddFoodItemDAL(foodItem);
            }
        public async Task<List<FoodItem>> GetAllFoodItemsBL()
            {
            return await _foodPointDAL.GetAllFoodItemsDAL();
            }

        public async Task<bool> UpdateItemBL(int id, FoodItem foodItem)
            {
            return await _foodPointDAL.UpdateItemDAL(id, foodItem);
            }
        //public async Task<bool> GetItemOnIdBL(int id)
        //    {
        //    return await _foodPointDAL.GetItemOnIdDAL(id);
        //    }
        public async Task<bool> AddCustomerBL(Customer customer)
            {
            return await _foodPointDAL.AddCustomerDAL(customer);
            }
        //public async Task<List<Customer>> GetAllCustomersBL()
        //    {
        //    return await _foodPointDAL.GetAllCustomersDAL();
        //    }
        public async Task<Customer> GetCustomerBL(int id)
            {
            return await _foodPointDAL.GetCustomerDAL(id);
            }
        public async Task<bool> DeleteCustomerBL(int id)
            {
            return await _foodPointDAL.DeleteCustomerDAL(id);
            }


        }
    }
