using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigBazarEntities;
using BigBazarExceptionLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BigBazarDataAccessLayer
    {
    public class BigBazarDAL : IBigBazarDAL
        {
        private readonly BigBazarDataBaseContext _BigBazarDBContext;
        static List<Purchase> purchaselist = new List<Purchase>();
        public BigBazarDAL(BigBazarDataBaseContext dataBaseContext)
            {
            _BigBazarDBContext = dataBaseContext;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        /// //***********************************************CATEGORY METHODS*************************************************
        //no for key
        public bool AddCategoryDAL(Category category)
            {
            int rowsaffected = 0;
            if(_BigBazarDBContext.Categories.FirstOrDefault(cat => cat.CategoryName == category.CategoryName) != null)
                {
                throw new DuplicateNameException("Category name already exits");
                }
            else
                {

                try
                    {
                    _BigBazarDBContext.Categories.Add(category);
                    rowsaffected = _BigBazarDBContext.SaveChanges();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(SqlException ex)
                    {
                    throw new Exception("sql server error occured", ex);
                    }
                catch(Exception ex)
                    {
                    throw ex;
                    }
                }
            }

        //delete category on id
        public bool DeleteCategoryDAL(int id)
            {
            int rowsAffected = 0;
            if(_BigBazarDBContext.Categories.FirstOrDefault(cat => cat.CategoryId == id) == null)
                {
                throw new CategoryNotFoundException("category id is not found");
                }
            else
                {

                Category categoryTemp = _BigBazarDBContext.Categories.FirstOrDefault(cat => cat.CategoryId == id);
                _BigBazarDBContext.Remove(id);
                rowsAffected = _BigBazarDBContext.SaveChanges();
                if(rowsAffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            }

        //show all categories list
        public List<Category> ShowAllCategoriesDAL()
            {

            List<Category> categories = _BigBazarDBContext.Categories.ToList();
            return categories;

            }







        //*****************************************CUSTOMER METHODS*************************************************
        //no foriegn key
        public bool AddCustomerDAL(Customer customer)
            {
            int rowsaffected = 0;
            if(_BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerName == customer.CustomerName && cus.PhoneNumber == customer.PhoneNumber) != null)
                {
                throw new DuplicateNameException("Customer already exits");
                }
            else
                {
                try
                    {
                    _BigBazarDBContext.Customers.Add(customer);
                    rowsaffected = _BigBazarDBContext.SaveChanges();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(SqlException ex)
                    {
                    throw new Exception("sql server error occured", ex);
                    }
                }

            }

        //edit/update customer
        public Customer EditCustomerDAL(int id)
            {
            try
                {
                //if(_BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerId == id) == null)
                //    {
                //    throw new CustomerIdNotFoundException("Customer id not found");
                //    }
                //else
                //    {
                    Customer custTemp = _BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerId == id);
                _BigBazarDBContext.Update(custTemp);
                    return custTemp;

                    //}
                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {

                throw ex;
                }
            }
        public bool EditCustomerDAL(Customer customer)
            {
            int rowsAffected = 0;

            try
                {
                //Customer _customer = bigBazarContext.Customers.SingleOrDefault(x => x.CustomerId == customer.CustomerId);

                _BigBazarDBContext.Update(customer);
                rowsAffected = _BigBazarDBContext.SaveChanges();
                if(rowsAffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }

                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }

            }




        //
        public Customer DeleteCustomerDAL(int id)
            {
            try
                {
                if(_BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerId == id) == null)
                    {
                    throw new CustomerIdNotFoundException("Customer id not found");
                    }
                else
                    {
                    Customer custTemp = _BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerId == id);
                    return custTemp;

                    }
                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {

                throw ex;
                }
            }

        public bool DeleteCustomerDAL(Customer customer)
            {
            int rowsAffected = 0;

            try
                {
                //Customer _customer = bigBazarContext.Customers.SingleOrDefault(x => x.CustomerId == customer.CustomerId);

                _BigBazarDBContext.Customers.Remove(customer);
                rowsAffected = _BigBazarDBContext.SaveChanges();
                if(rowsAffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }

                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }

            }



        //get customers list
        public List<Customer> ShowCustomerListDetailsDAL()
            {
            List<Customer> customers = _BigBazarDBContext.Customers.ToList();
            return customers;
            }


        //get customer
        public Customer ShowCustomerOnIdDAL(int id)
            {
            Customer customer = _BigBazarDBContext.Customers.FirstOrDefault(cus => cus.CustomerId == id);
            return customer;
            }


        //***********************************************PRODUCT METHODS*************************************************
        //has foreign key (category id)
        public bool AddProductDAL(Product product)
            {
            int rowsaffected = 0;
            
            try
                {
                _BigBazarDBContext.Products.Add(product);
                rowsaffected = _BigBazarDBContext.SaveChanges();
                if(rowsaffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            catch(SqlException ex)
                {
                throw new Exception("sql server error occured", ex);
                }
            catch(Exception ex)
                {
                throw ex;
                }


            }
        

            


        //get list of all products
        public List<Product> GetProductsListDetailsDAL()
            {
            try
                {

                List<Product> products = _BigBazarDBContext.Products.ToList();
                return products;
                }
            catch(NullReferenceException )
                {
                throw new Exception("list has not products");
                }
            catch(Exception ex)
                {
                throw ex;
                }

            }
        //get product list of particular category
        public List<Product> GetProductListForCategoryDAL(int categoryId)
            {
            try
                {
                List<Product> product = _BigBazarDBContext.Products.Where(x => x.CategoryId == categoryId).ToList<Product>();
                _BigBazarDBContext.SaveChangesAsync();
                if(product.Count > 0)
                    {
                    return product;
                    }

                return null;
                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }

            }

        //get count of products
        public int GetProductsCountDAL()
            {
            try
                {
                List<Product> products = _BigBazarDBContext.Products.ToList();
                return products.Count;
                }
            catch(NullReferenceException )
                {
                throw new Exception("list has not products");
                }

            }
       

        //delete product
        public bool DeleteProductDAL(int id)
            {
            int rowsAffected = 0;
            if(_BigBazarDBContext.Products.FirstOrDefault(p => p.ProductId == id) == null)
                {
                throw new ProductIdNotFoundException("product id is not found");
                }
            else
                {
                Product productTemp =  _BigBazarDBContext.Products.FirstOrDefault(p=> p.ProductId == id);
                _BigBazarDBContext.Products.Remove(productTemp);
                rowsAffected =  _BigBazarDBContext.SaveChanges();
                if(rowsAffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            }


        //update product
        public  bool UpdateProductDAL(Product products)
            {
            int rowsAffected = 0;
          //  Product productTemp =  _BigBazarDBContext.Products.FirstOrDefault(t => t.ProductId == products.ProductId);
            _BigBazarDBContext.Products.Update(products);
            rowsAffected =  _BigBazarDBContext.SaveChanges();
            if(rowsAffected == 0)
                {
                return false;
                }
            else
                {
                return true;
                }

            }



        //get product





        //***********************************************PURCHASE METHODS*************************************************
        //has product id as foreign key
        public bool AddPurchaseDetailsDAL(Purchase purchase)
            {
            int rowsaffected = 0;
            if( _BigBazarDBContext.Purchases.FirstOrDefault(pu=>pu.ProductId==purchase.ProductId) == null)
                {
                throw new ProductIdNotFoundException("This purchase details has no matched product id in products");
                }
            else
                {
                try
                    {
                    _BigBazarDBContext.Purchases.Add(purchase);
                    rowsaffected =  _BigBazarDBContext.SaveChanges();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(SqlException ex)
                    {
                    throw new Exception("sql server error occured", ex);
                    }

                }

            }

        //get list of purchase items and //get count of items 
        public List<Purchase> GetPurchaseListDetails()
            {
            try
                {
                List<Purchase> purchases = _BigBazarDBContext.Purchases.ToList();
                return purchases;
                }
            catch(SqlException ex)
                {
                throw new Exception("Server error occured!", ex);
                }
            }

        //get count of purchase items 
        public int GetCountOfPurchaseItemsDAL()
            {
            try
                {
                List<Purchase> purchases = _BigBazarDBContext.Purchases.ToList();
                return purchases.Count;
                }
            catch(SqlException ex)
                {
                throw new Exception("Server error occured!", ex);
                }
            }


        //delete purchase item




        //***********************************************RECEIPT METHODS*************************************************
        //depends on customer table for customer id
        //depents on purchase table to calculate the bill  and to count the items (write a method to get count of items from purchase list)
        public bool GenerateReceiptDAL(Receipt receipt)//i need to have the couunt of purchase items,total bill calculation
            {
            int rowsaffected = 0;
            if( _BigBazarDBContext.Purchases.FirstOrDefault(re=>re.CustomerId==receipt.CustomerId) == null)
                {
                throw new CustomerIdNotFoundException("this customer id is not present");
                }

            else
                {
                try
                    {
                    _BigBazarDBContext.Receipts.Add(receipt);
                    rowsaffected =  _BigBazarDBContext.SaveChanges();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(SqlException ex)
                    {
                    throw new Exception("sql server error occured", ex);
                    }

                }

            }


        //get receipt


        //***********************************************USER METHODS*************************************************

        public bool AddUserDAL(User user)//user has only two roles>>>user or admin
            {
            int rowsaffected = 0;
            try
                {
                if(user != null)
                    {
                    _BigBazarDBContext.Users.Add(user);
                    rowsaffected= _BigBazarDBContext.SaveChanges();
                     if(rowsaffected != 0)
                        return true;
                    }
                //else if(_BigBazarDBContext.Users.FirstOrDefault(us => us.UserRole == "Admin" || us.UserRole == "User") == null)
                //    {
                //    throw new RoleNotPermittedException("The user's role must be either 'User' or 'Admin' to login");
                //    }
                //else if(_BigBazarDBContext.Users.FirstOrDefault(us => us.UserId == user.UserId && us.UserName == user.UserName) != null)
                //    {
                //    throw new UserAlreadyExistsException("User already exists ");
                //    }
                return false;

                }
            catch(SqlException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                           
                }


            }

        //get user
        public string GetUserRoleDAL(User user)
            {
            try
                {
                //if(_BigBazarDBContext.Users.FirstOrDefault(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword) != null)
                if(user!=null)
                    {
                    User userRole = _BigBazarDBContext.Users.FirstOrDefault(r => r.UserName == user.UserName && r.UserPassword==user.UserPassword );
                    return userRole.UserRole;
                    }
                else
                    {
                    return null;
                    }
                }
            catch(SqlException ex)
                {
                throw new Exception("Server error occured",ex);
                }
            }

        //delete user
        public  bool DeleteUserDAL(int id)
            {
            int rowsAffected = 0;
            if( _BigBazarDBContext.Users.FirstOrDefault(p => p.UserId == id) == null)
                {
                throw new ProductIdNotFoundException("user id is not found");
                }
            else
                {
                User userTemp =_BigBazarDBContext.Users.FirstOrDefault(p => p.UserId == id);
                _BigBazarDBContext.Remove(id);
                rowsAffected =  _BigBazarDBContext.SaveChanges();
                if(rowsAffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            }



///////////////////////////////////////////////////////////////////////////
 
        
        
        public  int GetPurchaseIdDAL()
        {
            try
            {

                if (purchaselist.Count() == 0)
                {
                    return 1;
                }
                else
                {
                    List<Purchase> purchases = purchaselist.OrderByDescending(x => x.PurchaseId).Where(x => x.PurchaseId > 0).ToList<Purchase>();
                    _BigBazarDBContext.SaveChangesAsync();
                    return ((int)(purchases[0].PurchaseId + 1));
                }
            }
            catch(ArithmeticException ex)
            {
                 throw ex;
                 }
            catch(SqlException ex)
                  {
                  throw ex;
                   }
             catch(Exception ex)
                {
                throw ex;
                 }

        }

        public bool AddToPurchaseListDAL(int productId, int purchaseId)
         {
         try
        {
        Product product = _BigBazarDBContext.Products.SingleOrDefault(x => x.ProductId == productId);
        Purchase purchase = new Purchase();
        purchase.Product = product;
        purchase.ProductId = product.ProductId;
        purchase.PurchaseQuantity = product.ProductQuantity;
        purchase.DateOfPurchase = System.DateTime.Now;
        purchase.PurchasePrice = product.ProductPrice;
        purchase.PurchaseId = purchaseId;
        purchaselist.Add(purchase);
        return true;

        }
        catch(NullReferenceException ex)
        {
        throw ex;
        }
        catch(SqlException ex)
        {
        throw ex;
        }
        catch(Exception ex)
        {
        throw ex;
        }

    }

        public Receipt GenerateReciptDAL()
          {

           try
        
                {
        Receipt receipt = new Receipt
            {
            ReceiptId = _BigBazarDBContext.Receipts.Count() + 1,
            NoOfItems = purchaselist.Count()
            };
        double totalBill = 0;
        foreach(Purchase purchase in purchaselist)
            {
              totalBill = (double)(totalBill + (purchase.PurchasePrice));
            }
        receipt.TotalBill = (int)totalBill;
        purchaselist = new List<Purchase>();

        return receipt;
        }
    catch(ArithmeticException ex)
        {
        throw ex;
        }
    catch(SqlException ex)
        {
        throw ex;
        }
    catch(Exception )
        {
        throw new   ReceiptGenerationFailedException("ReceiptGeneration Has Failed");
        }

    }









        }
    }
