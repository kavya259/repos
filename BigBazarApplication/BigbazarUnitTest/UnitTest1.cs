using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBazarDataAccessLayer;
using BigBazarBusinessLayer;
using BigBazarEntities;
using System.Collections.Generic;

namespace BigbazarUnitTest
    {
    [TestClass]
    public class UnitTest1
        {
        
            BigBazarDataAccessLayer.BigBazarDataBaseContext bigBazarDataBase = new BigBazarDataAccessLayer.BigBazarDataBaseContext();
            IBigBazarDAL repository;
            IBigBazarBL userServices;

            [TestInitialize]
            public void InitializeForTests()
                {
                repository = new BigBazarDAL(bigBazarDataBase);
                userServices = new BigBazarBL(repository);
                }
        [TestMethod]
        public void TestAddUser()
            {
            User user = new User() { UserName = "abcd", UserPassword = "abcd",UserRole="User" };
            bool result =  repository.AddUserDAL(user);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public void TestDeleteCustomer()
            {

            Customer customer = new Customer { CustomerId = 1 };
            bool result =  repository.DeleteCustomerDAL(customer);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public void TestDeleteProduct()
            {
            bool result =  repository.DeleteProductDAL(33);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public void TestAddCategory()
            {
            Category category = new Category() { CategoryName = "others" };
            bool result =  repository.AddCategoryDAL(category);
            Assert.AreEqual(true, result);
            }
        [TestMethod]
        public void TestEditProduct()
            {
            Product product = new Product() { ProductId = 8, ProductName = "Watch", ProductQuantity = 1, ProductPrice = 100, CategoryId = 2 };
            bool reusult =  repository.UpdateProductDAL(product);
            Assert.AreEqual(true, reusult);
            }
        [TestMethod]
        public void TestEditCustomer()
            {
            Customer customer = new Customer() { CustomerId = 2002, CustomerName = "Virat", Email = "viart@gmail.com", PhoneNumber = "7896782689" };
            bool reusult =  repository.EditCustomerDAL(customer);
            Assert.AreEqual(false, reusult);
            }

        [TestMethod]
        public  void TestCategoryList()
                {
                List<Category> category = new List<Category>();
                category.Add(new Category { CategoryId = 18, CategoryName = "xyz" });
                category.Add(new Category { CategoryId = 20, CategoryName = "abc" });
                
                List<Category> _category =  repository.ShowAllCategoriesDAL();
                Assert.AreEqual(5, _category.Count);




            }
        }
        }
    
