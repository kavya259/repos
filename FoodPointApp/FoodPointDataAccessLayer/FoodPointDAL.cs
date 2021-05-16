using FoodPointEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodPointExceptionLayer;

namespace FoodPointDataAccessLayer
    {
    public class FoodPointDAL : IFoodPointDAL
        {
        private readonly FoodDBContext foodDBContext;
        public FoodPointDAL(FoodDBContext foodb)
            {
            foodDBContext = foodb;
            }

        //add food item,returns true if added 
        public async Task<bool> AddFoodItemDAL(FoodItem foodItem)
            {
            int rowsaffected = 0;
            if(await foodDBContext.FoodItems.FirstOrDefaultAsync(n => n.ItemName == foodItem.ItemName) != null)
                {
                throw new DuplicateFoodItemNameException("Food item name entered already exits in the menu,enter a different one");
                }
            else
                {
                try
                    {

                    foodDBContext.Add(foodItem);
                    rowsaffected = await foodDBContext.SaveChangesAsync();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("There must be server error ", ex);
                    }
                }

            }
        //to get all items=>returns list of all food items
        public async Task<List<FoodItem>> GetAllFoodItemsDAL()
            {
            List<FoodItem> itemsList = await foodDBContext.FoodItems.ToListAsync();
            return itemsList;
            }

        //method for updating=>takes item id as input to update that particular item details
        public async Task<bool> UpdateItemDAL(int id,FoodItem foodItem)
            {
            int rowsaffected = 0;

            if(await foodDBContext.FoodItems.FirstOrDefaultAsync(s => s.ItemId == id) == null)
                {
                throw new IdNotFoundException("item Id is not present");
                }
            else
                {
                try
                    {
                    FoodItem tempItem = await foodDBContext.FoodItems.FirstOrDefaultAsync(t => t.ItemId == id);
                    tempItem.ItemName = foodItem.ItemName;
                  //  foodDBContext.Update(tempItem);
                    rowsaffected = await foodDBContext.SaveChangesAsync();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch (Exception ex)
                    {
                    throw new SqlException("server error occured", ex);
                    }
                }

            }





        //to add customers
        public async Task<bool> AddCustomerDAL(Customer customer)
            {
            int rowsaffected = 0;
            try
                {

                foodDBContext.Add(customer);
                rowsaffected = await foodDBContext.SaveChangesAsync();
                if(rowsaffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            catch(FormatException ex)
                {
                throw new IncorrectFormatException("check format for name", ex);
                }
            catch(Exception ex)
                {
                throw new SqlException("There must be server error ", ex);
                }
            }



        // to delete a customer based on id
        public async Task<bool> DeleteCustomerDAL(int id)
            {
            if(await foodDBContext.Customers.FirstOrDefaultAsync(s => s.CustomerId == id) == null)
                {
                throw new IdNotFoundException("Id is not found");
                }
            else
                {
                try
                    {
                    int rowsAffected = 0;
                    Customer tempcustomer = await foodDBContext.Customers.FirstOrDefaultAsync(t => t.CustomerId == id);
                    foodDBContext.Remove(tempcustomer);
                    rowsAffected = await foodDBContext.SaveChangesAsync();
                    if(rowsAffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("server error occured!" + ex.InnerException, ex);
                    }
                }
            }


        //************************************************************************************************************
        //to retrieve a customer based on id
        public async Task<Customer> GetCustomerDAL(int id)
            {
            if(await foodDBContext.Customers.FirstOrDefaultAsync(s => s.CustomerId == id) == null)
                {
                throw new IdNotFoundException("Id is not found");
                }
            else
                {
                try
                    {
                    Customer tempcustomer = await foodDBContext.Customers.FirstOrDefaultAsync(t => t.CustomerId == id);
                   
                        await foodDBContext.SaveChangesAsync();
                    return tempcustomer;
                    }
                catch(Exception ex)
                    {
                    throw new SqlException("server error occured!" + ex.InnerException, ex);
                    }


                }
            }
        }
    }
