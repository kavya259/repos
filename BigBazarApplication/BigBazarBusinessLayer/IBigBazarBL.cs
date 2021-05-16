using BigBazarEntities;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BigBazarBusinessLayer
    {
    public interface IBigBazarBL
        {
        string GetUserRoleBL(User user);
        bool AddUserBL(User user);
        bool AddCategoryBL(Category category);
        List<Category> ShowAllCategoriesBL();
        bool DeleteCategoryBL(int id);
        bool AddCustomerBL(Customer customer);
        Customer EditCustomerBL(int id);
        bool EditCustomerBL(Customer customer);          
        Customer DeleteCustomerBL(int id);
        bool DeleteCustomerBL(Customer customer);
        List<Customer> ShowCustomerListDetailsBL();
        Customer ShowCustomerOnIdBL(int id);
        bool AddProductBL(Product product);
        List<Product> GetProductsListDetailsBL();
        List<Product> GetProductListForCategoryBL(int categoryId);
        bool DeleteProductBL(int id);
        bool UpdateProductBL(Product products);
        int GetPurchaseIdBL();
        bool AddToPurchaseListBL(int productId, int purchaseId);
        Receipt GenerateReciptBL();


            }
    }
