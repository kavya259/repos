using FoodPointEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodPointDataAccessLayer
    {
    public interface IFoodPointDAL
        {
        Task<bool> AddFoodItemDAL(FoodItem foodItem);
        Task<List<FoodItem>> GetAllFoodItemsDAL();
        Task<bool> UpdateItemDAL(int id, FoodItem foodItem);
        //Task<bool> GetItemOnIdDAL(int id);
        Task<bool> AddCustomerDAL(Customer customer);
        //Task<List<Customer>> GetAllCustomersDAL();
        Task<Customer> GetCustomerDAL(int id);
        Task<bool> DeleteCustomerDAL(int id);
        }
    }
