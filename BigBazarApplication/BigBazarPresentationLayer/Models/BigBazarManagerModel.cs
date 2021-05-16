using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigBazarEntities;

namespace BigBazarPresentationLayer.Models
    {
    public class BigBazarManagerModel
        {
        //Customer mapping
        public Customer ModelToEntity(CustomerModel customerModelObj)
            {
            Customer customerObj = new Customer();

            customerObj.CustomerId = customerModelObj.CustomerId;
            customerObj.CustomerName = customerModelObj.CustomerName;
            customerObj.Email = customerModelObj.Email;
            customerObj.PhoneNumber = customerModelObj.PhoneNumber;

            return customerObj;
            }

        public CustomerModel EntityToModel(Customer customerObj)
            {
            CustomerModel customerModelObj = new CustomerModel();

            customerModelObj.CustomerId = customerObj.CustomerId;
            customerModelObj.CustomerName = customerObj.CustomerName;
            customerModelObj.Email = customerObj.Email;
            customerModelObj.PhoneNumber = customerObj.PhoneNumber;

            return customerModelObj;
            }

        //Category mapping
        public Category ModelToEntity(CategoryModel categoryModelObj)
            {
            Category categoryObj = new Category();

            categoryObj.CategoryId = categoryModelObj.CategoryId;
            categoryObj.CategoryName = categoryModelObj.CategoryName;

            return categoryObj;
            }
        public CategoryModel EntityToModel(Category categoryObj)
            {
            CategoryModel categoryModelObj = new CategoryModel();

            categoryModelObj.CategoryId = categoryObj.CategoryId;
            categoryModelObj.CategoryName = categoryObj.CategoryName;

            return categoryModelObj;
            }

        //User mapping
        public User ModelToEntity(UserModel userModelObj)
            {
            User userObj = new User();

            userObj.UserId = userModelObj.UserId;
            userObj.UserName = userModelObj.UserName;
            userObj.UserRole = userModelObj.UserRole;
            userObj.UserPassword = userModelObj.UserPassword;

            return userObj;
            }
        public UserModel EntityToModel(User userObj)
            {
            UserModel userModelObj = new UserModel();

            userModelObj.UserId = userObj.UserId;
            userModelObj.UserName = userObj.UserName;
            userModelObj.UserRole = userObj.UserRole;
            userModelObj.UserPassword = userObj.UserPassword;

            //userModelObj.UserPassword = "**********";

            return userModelObj;
            ;
            }

        //Product mapping
        public Product ModelToEntity(ProductModel productModelObj)
            {
            Product productObj = new Product();

            productObj.ProductId = productModelObj.ProductId;
            productObj.ProductName = productModelObj.ProductName;
            productObj.ProductQuantity = productModelObj.ProductQuantity;
            productObj.ProductPrice = productModelObj.ProductPrice;
            productObj.CategoryId = productModelObj.CategoryId;

            return productObj;
            }
        public ProductModel EntityToModel(Product productObj)
            {
            ProductModel productModelObj = new ProductModel();

            productModelObj.ProductId = productObj.ProductId;
            productModelObj.ProductName = productObj.ProductName;
            productModelObj.ProductQuantity = productObj.ProductQuantity;
            productModelObj.ProductPrice = productObj.ProductPrice;
            productModelObj.CategoryId = productObj.CategoryId;

            return productModelObj;
            }

        //Receipt mapping
        public Receipt ModelToEntity(ReceiptModel receiptModelObj)
            {
            Receipt receiptObj = new Receipt();

            receiptObj.ReceiptId = receiptModelObj.ReceiptId;
            receiptObj.ReceiptDate = receiptModelObj.ReceiptDate;
            receiptObj.CustomerId = receiptModelObj.CustomerId;
            receiptObj.TotalBill = receiptModelObj.TotalBill;
            receiptObj.NoOfItems = receiptModelObj.NoOfItems;

            return receiptObj;
            }
        public ReceiptModel EntityToModel(Receipt receiptObj)
            {
            ReceiptModel receiptModelObj = new ReceiptModel();

            receiptModelObj.ReceiptId = receiptObj.ReceiptId;
            receiptModelObj.ReceiptDate = receiptObj.ReceiptDate;
            receiptModelObj.CustomerId = receiptObj.CustomerId;
            receiptModelObj.TotalBill = receiptObj.TotalBill;
            receiptModelObj.NoOfItems = receiptObj.NoOfItems;

            return receiptModelObj;
            }

        //Purchase mappings
        public Purchase ModelToEntity(PurchaseModel purchaseModelObj)
            {
            Purchase purchaseObj = new Purchase();

            purchaseObj.PurchaseId = purchaseModelObj.PurchaseId;
            purchaseObj.ProductId = purchaseModelObj.ProductId;
            purchaseObj.PurchaseQuantity = purchaseModelObj.PurchaseQuantity;
            purchaseObj.PurchasePrice = purchaseModelObj.PurchasePrice;
            purchaseObj.DateOfPurchase = purchaseModelObj.DateOfPurchase;

            return purchaseObj;
            }
        public PurchaseModel EntityToModel(Purchase purchaseObj)
            {
            PurchaseModel purchaseModelObj = new PurchaseModel();

            purchaseModelObj.PurchaseId = purchaseObj.PurchaseId;
            purchaseModelObj.ProductId = purchaseObj.ProductId;
            purchaseModelObj.PurchaseQuantity = purchaseObj.PurchaseQuantity;
            purchaseModelObj.PurchasePrice = purchaseObj.PurchasePrice;
            purchaseModelObj.DateOfPurchase = purchaseObj.DateOfPurchase;

            return purchaseModelObj;
            }

        }
    }
