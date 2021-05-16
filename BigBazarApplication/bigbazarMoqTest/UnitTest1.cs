using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBazarDataAccessLayer;
using BigBazarBusinessLayer;
using BigBazarEntities;
using Moq;
namespace bigbazarMoqTest
    {
    [TestClass]
    public class UnitTest1
        {
       
        [TestMethod]
    public  void TestDeleteCustomer()
        {
        var mock = new Mock<IBigBazarDAL>();
        mock.Setup(p => p.DeleteCustomerDAL(new Customer() { CustomerId = 2002 })).Returns(false);
        BigBazarBL service = new BigBazarBL(mock.Object);
        bool result =  service.DeleteCustomerBL(new Customer() { CustomerId = 2002 });
        Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AddUser_ReturnsTrue()
            {
            var mock = new Mock<IBigBazarDAL>();
            User user = new User();
            user.UserName = "ja";
            user.UserRole = "Admin";
            user.UserPassword = "ja";
            mock.Setup(p => p.AddUserDAL(user)).Returns(true);
            bool result = mock.Object.AddUserDAL(user);
            Assert.AreEqual(true, result);
            }


        [TestMethod]
        public void AddCategory_ReturnsTrue()
            {
            var mock = new Mock<IBigBazarDAL>();
            Category category = new Category();
            category.CategoryName = "Footwear";
            mock.Setup(p => p.AddCategoryDAL(category)).Returns(true);
            bool result = mock.Object.AddCategoryDAL(category);
            Assert.AreEqual(true, result);
            }


        [TestMethod]
        public void AddProduct_ReturnsTrue()
            {
            var mock = new Mock<IBigBazarDAL>();
            Product product = new Product();

            mock.Setup(p => p.AddProductDAL(product)).Returns(true);
            bool result = mock.Object.AddProductDAL(product);
            Assert.AreEqual(true, result);
            }




        [TestMethod]
        public void DeleteCategory_ReturnsTrue()
            {
            var mock = new Mock<IBigBazarDAL>();

            mock.Setup(p => p.DeleteCategoryDAL(100)).Returns(true);
            bool result = mock.Object.DeleteCategoryDAL(100);
            Assert.AreEqual(true, result);
            }


        [TestMethod]
        public void DeleteProduct_ReturnsTrue()
            {
            var mock = new Mock<IBigBazarDAL>();

            mock.Setup(p => p.DeleteProductDAL(100)).Returns(true);
            bool result = mock.Object.DeleteProductDAL(100);
            Assert.AreEqual(true, result);
            }

        }
    }
    
