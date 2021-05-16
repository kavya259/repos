using BigBazarEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BigBazarDataAccessLayer
    {
    public interface IBigBazarDAL
        {
        string GetUserRoleDAL(User user);
        bool AddUserDAL(User user);
        //CATEGORY*******************************************************
        bool AddCategoryDAL(Category category);
        List<Category> ShowAllCategoriesDAL();
        bool DeleteCategoryDAL(int id);
        //CUSTOMER*******************************************************
        bool AddCustomerDAL(Customer customer);
        Customer DeleteCustomerDAL(int id);
        bool DeleteCustomerDAL(Customer customer);
        Customer EditCustomerDAL(int id);
        bool EditCustomerDAL(Customer customer);
        List<Customer> ShowCustomerListDetailsDAL();
        Customer ShowCustomerOnIdDAL(int id);
        //PRODUCTS*********************************************************
        bool AddProductDAL(Product product);
        List<Product> GetProductsListDetailsDAL();
        List<Product> GetProductListForCategoryDAL(int categoryId);
        bool DeleteProductDAL(int id);
        bool UpdateProductDAL(Product products);
        int GetPurchaseIdDAL();
        bool AddToPurchaseListDAL(int productId, int purchaseId);
        Receipt GenerateReciptDAL();


        }
    }
