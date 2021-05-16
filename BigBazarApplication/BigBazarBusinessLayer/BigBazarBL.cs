using BigBazarEntities;
using System;
using System.Collections.Generic;
using System.Text;
using BigBazarDataAccessLayer;
using System.Threading.Tasks;

namespace BigBazarBusinessLayer
    {
    public class BigBazarBL : IBigBazarBL
        {
        //IBigBazarDAL _bigBazarDAL = new BigBazarDAL();
        private readonly IBigBazarDAL _bigBazarDAL;
        public BigBazarBL(IBigBazarDAL bigBazarDAL)
            {
            this._bigBazarDAL = bigBazarDAL;
            }


        public string GetUserRoleBL(User user)
            {
            return _bigBazarDAL.GetUserRoleDAL(user);
            }
        public  bool AddUserBL(User user)
            {
            return  _bigBazarDAL.AddUserDAL(user);
            }

        public  bool AddCategoryBL(Category category)
            {
            return  _bigBazarDAL.AddCategoryDAL(category);
            }
        public  List<Category> ShowAllCategoriesBL()
            {
            return  _bigBazarDAL.ShowAllCategoriesDAL();
            }

        public  bool DeleteCategoryBL(int id)
            {
            return  _bigBazarDAL.DeleteCategoryDAL(id);
            }
        public bool AddCustomerBL(Customer customer)
            {
            return _bigBazarDAL.AddCustomerDAL(customer);
            }
        public Customer EditCustomerBL(int id)
            {
            return _bigBazarDAL.EditCustomerDAL(id);
            }
        public bool EditCustomerBL(Customer customer)
            {
            return _bigBazarDAL.EditCustomerDAL(customer);
            }
        public Customer DeleteCustomerBL(int id)
            {
            return _bigBazarDAL.DeleteCustomerDAL(id);
            }
        public bool DeleteCustomerBL(Customer customer)
            {
            return _bigBazarDAL.DeleteCustomerDAL(customer);
            }

        public List<Customer> ShowCustomerListDetailsBL()
            {
            return _bigBazarDAL.ShowCustomerListDetailsDAL();
            }
        public Customer ShowCustomerOnIdBL(int id)
            {
            return _bigBazarDAL.ShowCustomerOnIdDAL(id);
            }
        public bool AddProductBL(Product product)
            {
            return _bigBazarDAL.AddProductDAL(product);
            }
        public List<Product> GetProductsListDetailsBL()
            {
            return _bigBazarDAL.GetProductsListDetailsDAL();
            }
        public List<Product> GetProductListForCategoryBL(int categoryId)
            {
            return _bigBazarDAL.GetProductListForCategoryDAL(categoryId);
            }

        public bool DeleteProductBL(int id)
            {
            return _bigBazarDAL.DeleteProductDAL(id);

            }
        public bool UpdateProductBL(Product products)
            {
            return _bigBazarDAL.UpdateProductDAL(products);
            }
        public int GetPurchaseIdBL()
            {
            return _bigBazarDAL.GetPurchaseIdDAL();
            }
        public bool AddToPurchaseListBL(int productId, int purchaseId)
            {
            return _bigBazarDAL.AddToPurchaseListDAL(productId, purchaseId);
            }
        public Receipt GenerateReciptBL()
            {
            return _bigBazarDAL.GenerateReciptDAL();
            }
        }
    }
