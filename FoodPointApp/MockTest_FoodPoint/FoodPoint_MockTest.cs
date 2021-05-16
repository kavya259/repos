using FoodPointDataAccessLayer;
using FoodPointEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using FoodPointBusinessLayer;
using System.Collections.Generic;

namespace MockTest_FoodPoint
    {
    [TestClass]
    public class FoodPoint_MockTest
        {
        [TestMethod]
        public async Task Test_AddItem_ReturnsTrue_IfAdded()
            {
            var mock = new Mock<IFoodPointDAL>();
            FoodItem foodItem = new FoodItem();
            foodItem.ItemName = "john";
            mock.Setup(p => p.AddFoodItemDAL(foodItem)).ReturnsAsync(true);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            var isAdded = await foodPointBL.AddFoodItemBL(foodItem);
            Assert.AreEqual(true, isAdded);
            }

        [TestMethod]
        public async Task Test_GetItems_returns_count()
            {
            var mock = new Mock<IFoodPointDAL>();
            List<FoodItem> foods = new List<FoodItem>();
            mock.Setup(p => p.GetAllFoodItemsDAL()).ReturnsAsync(foods);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            List<FoodItem> result = await foodPointBL.GetAllFoodItemsBL();           
            Assert.AreEqual(0, result.Count);
            }

        [TestMethod]
        public async Task Test_UpdateItem_returns_true_IfUpdated()
            {
            var mock = new Mock<IFoodPointDAL>();
            FoodItem foodItem = new FoodItem();
            foodItem.ItemId = 2;
            foodItem.ItemName = "NewItem1";
            mock.Setup(p => p.UpdateItemDAL(foodItem.ItemId, foodItem)).ReturnsAsync(true);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            var result = await foodPointBL.UpdateItemBL(foodItem.ItemId, foodItem);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public async Task Test_AddCustomers_ReturnsTrue_IfAdded()
            {
            var mock = new Mock<IFoodPointDAL>();
            Customer customer = new Customer();
            customer.CustomerName = "someName1";
            customer.MobileNo = "8736776273";
            customer.ItemId = 1;
            mock.Setup(p => p.AddCustomerDAL(customer)).ReturnsAsync(true);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            var result = await foodPointBL.AddCustomerBL(customer);
            Assert.AreEqual(true, result);
            }

        [TestMethod]
        public async Task Test_GetCustomer_returnsCorrectName_IfRetrieved()
            {
            var mock = new Mock<IFoodPointDAL>();
            int SearchId = 2;

            Customer customer = new Customer();
            customer.CustomerId = 2;
            customer.CustomerName = "someone";
            customer.MobileNo = "1226678888";
            customer.ItemId = 1;
            mock.Setup(p => p.GetCustomerDAL(SearchId)).ReturnsAsync(customer);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            var result = await foodPointBL.GetCustomerBL(SearchId);
            Assert.AreEqual(customer, result);
            //Assert.AreEqual("priya", result.CustomerName);

            }
        [TestMethod]
        public async Task Test_DeleteCustomer_returns()
            {
            var mock = new Mock<IFoodPointDAL>();
            int DeleteId = 5;
            mock.Setup(p => p.DeleteCustomerDAL(DeleteId)).ReturnsAsync(true);
            FoodPointBL foodPointBL = new FoodPointBL(mock.Object);
            var result = await foodPointBL.DeleteCustomerBL(DeleteId);
            Assert.AreEqual(true, result);
            }
        }
    }
