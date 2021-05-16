using FoodPointEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodPointBusinessLayer
    {
    public interface IFoodPointBL
        {
        Task<bool> AddFoodItemBL(FoodItem foodItem);
        Task<List<FoodItem>> GetAllFoodItemsBL();
        Task<bool> UpdateItemBL(int id, FoodItem foodItem);
        //Task<bool> GetItemOnIdBL(int id);
        Task<bool> AddCustomerBL(Customer customer);
        //Task<List<Customer>> GetAllCustomersBL();
        Task<Customer> GetCustomerBL(int id);
        Task<bool> DeleteCustomerBL(int id);
        }
    }
