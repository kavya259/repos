using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using FoodPointBusinessLayer;
using FoodPointDataAccessLayer;
using FoodPointEntities;
using System.Threading;
using System.Collections.Generic;
using System.Configuration;

namespace UnitTest_FoodPointApp
    {
    [TestClass]
    public class FoodPoint_UnitTest
        {
        FoodDBContext foodDBContext=new FoodDBContext();
        IFoodPointBL _foodPointBL;
        IFoodPointDAL _foodPointDAL;

        [TestInitialize]
        public void InitializeDependencies()
            {
            _foodPointDAL = new FoodPointDAL(foodDBContext);
            _foodPointBL = new FoodPointBL(_foodPointDAL);
           
            }


        [TestMethod]
        public async Task Test_AddItem_ReturnsTrue_IfAdded()
            {
            FoodItem foodItem = new FoodItem();
            //foodItem.ItemId=4;
            foodItem.ItemName = "Bob";
            var isAdded = await _foodPointBL.AddFoodItemBL(foodItem);
            Assert.AreEqual(true,isAdded);
            }

        [TestMethod]
        public async Task Test_GetItems_returns_count()
            {
            var result = await _foodPointBL.GetAllFoodItemsBL();
            Assert.AreEqual(4, result.Count);
            }

        [TestMethod]
        public async Task Test_UpdateItem_returns_true_IfUpdated()
            {
            FoodItem foodItem = new FoodItem();
            foodItem.ItemId = 1;
            foodItem.ItemName = "NewItem";
            var result = await _foodPointBL.UpdateItemBL(foodItem.ItemId, foodItem);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public async Task Test_AddCustomers_ReturnsTrue_IfAdded()
            {
            Customer customer = new Customer();
            customer.CustomerName = "someName";
            customer.MobileNo = "8736776272";
            customer.ItemId =1;
            var result = await _foodPointBL.AddCustomerBL(customer);
            Assert.AreEqual(true, result);
            }

        [TestMethod]
        public async Task Test_GetCustomer_returnsCorrectName_IfRetrieved()
            {
            int SearchId = 2;
            var result = await _foodPointBL.GetCustomerBL(SearchId);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("priya", result.CustomerName);

            }
        [TestMethod]
        public async Task Test_DeleteCustomer_returns()
            {
            int DeleteId = 5;
            var result = await _foodPointBL.DeleteCustomerBL(DeleteId);
            Assert.AreEqual(true, result);
            }
       
        }
    }
