using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigBazarPresentationLayer.Models;
using BigBazarBusinessLayer;
using BigBazarExceptionLayer;
using Microsoft.Data.SqlClient;
using BigBazarEntities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BigBazarPresentationLayer.Controllers
    {
    public class UserController : Controller
        {
         public readonly IBigBazarBL _bigBazarBL;
        static int purchaseId = 0;
        static int reciept = 100;
        public UserController(IBigBazarBL bigBazarBL)
            {
            this._bigBazarBL = bigBazarBL;
            }
        private BigBazarManagerModel managerModel = new BigBazarManagerModel();
        private static List<Product> _products = new List<Product>();

        public IActionResult Index()
            {
            return View();
            }

        [HttpGet]
        public ActionResult AddCustomer()
            {
            return View();
            }
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customerModel)
            {
            try
                {
                if(_bigBazarBL.AddCustomerBL(managerModel.ModelToEntity(customerModel)))
                    {
                    return View();
                    }
                return View();
                }
            catch(DuplicateNameException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpGet]
        public ActionResult EditCustomer(int customerId)
            {
            /*The Details Of The customer with the
             * given customer id gets Updated 
             * in the Customer table in database*/
            try
                {
                Customer customer = _bigBazarBL.EditCustomerBL(customerId);
                return View(customer);
                }
            catch(CustomerIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerMessage = ex.InnerException;
                return View();
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            }
        [HttpPost]
        public ActionResult EditCustomer(Customer customer)
            {
            /*This Action Will Update the Details Of the
             * Customer whose Value Has Posted
             * from the view */
            try
                {
                if( _bigBazarBL.EditCustomerBL(customer))
                    {
                    return View();
                    }
                return View();
                }
            catch(CustomerIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerMessage = ex.InnerException;
                return View();
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }

        [HttpGet]
        public ActionResult DeleteCustomer(int customerId)
            {
            /*When This Action Has Called the Customer With
             * Given customerId Will get Removed From the
             * Customer Table */
            try
                {
                Customer customer =  _bigBazarBL.DeleteCustomerBL(customerId);
                return View(customer);
                }
            catch(CustomerIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerMessage = ex.InnerException;
                return View();
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpPost]
        public ActionResult DeleteCustomer(CustomerModel customermodel)
            {
            try
                {
                bool result =  _bigBazarBL.DeleteCustomerBL(managerModel.ModelToEntity(customermodel));

                return View();
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            }
        [HttpGet]
        public ActionResult GetAllCustomers()
            {
            try
                {
                List<Customer> customers = _bigBazarBL.ShowCustomerListDetailsBL();
                return View(customers);
                }
            catch(CategoryNotFoundException ex)
                 {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
       
       
        [HttpGet]
        public ActionResult AddProduct(int _categoryId)
            {
            try
                {
                ProductModel product = new ProductModel();
                product.CategoryId = _categoryId;
                return View(product);
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }


        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
            {
            try
                {
                if(_bigBazarBL.AddProductBL(managerModel.ModelToEntity(productModel)))
                    {
                    return View();
                    }
                return View();
                }
            catch(DuplicateNameException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpGet]
        public  ActionResult DeleteProduct(int _productId)
            {
            
            try
                {
                if( _bigBazarBL.DeleteProductBL(_productId))
                    {
                    return RedirectToAction("GetAllProducts");
                    }
                return RedirectToAction("GetAllProducts");
                }
            catch(ProductIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerException = ex.InnerException;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpGet]
        public ActionResult EditProduct(int _productId, int _categoryId)
            {
            try
                {
                Product product = new Product();
                product.ProductId = _productId;
                product.CategoryId = _categoryId;
                List<Category> categories = _bigBazarBL.ShowAllCategoriesBL();
                ViewBag.Category = new SelectList(categories, "CategoryId", "CategoryName");   
                
                return View(product);
                }
            catch(ProductIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerException = ex.InnerException;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpPost]
        public ActionResult EditProduct(Product product)
            {
            try
                {
                bool result =  _bigBazarBL.UpdateProductBL(product);
             //   ViewBag.CategoryId = product.CategoryId;
                return View();
                }
            catch(ProductIdNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerException = ex.InnerException;
                return View();
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }



        [HttpGet]
        public ActionResult GetAllProducts()
            {
            try
                {
                List<Product> products = _bigBazarBL.GetProductsListDetailsBL();
                return View(products);
                }
            catch(CategoryNotFoundException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }

        [HttpGet]
        public ActionResult GetAllProductsForCategory(int categoryId)
            {
            /* This Action Will return the View Of All Products Under
             * the Given Category Id*/
            try
                {
                List<Product> product =  _bigBazarBL.GetProductListForCategoryBL(categoryId);
                return View(product);
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpGet]
        public  ActionResult CategoryDropDown()
            {
            try
                {
                purchaseId =  _bigBazarBL.GetPurchaseIdBL();

                List<Category> catergories =  _bigBazarBL.ShowAllCategoriesBL();
                //Generate the  Dropdown of categories in this view
                ViewBag.Category = new SelectList(catergories, "CategoryId", "CategoryName");

                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpPost]
        public ActionResult CategoryDropDown(CategoryModel categorymodel)
            {
            
            try
                {
                int categoryId = categorymodel.CategoryId;
                _products.Clear();
                //ViewBag.Category = new SelectList(catergories, "CategoryId", "CategoryName");
                List<Product> products=_bigBazarBL.GetProductListForCategoryBL(categoryId);
                if(products == null)
                    {
                    ViewBag.Message = "No Products  Found Under This category";
                    return View();
                    }
                _products = products;
                
                return RedirectToAction("SelectedPurchaseItems");
                    
                }
            catch(NullReferenceException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }


            }
        [HttpGet]
        public ActionResult SelectedPurchaseItems()
            {                
                /*This Action Will return the view of 
                 * List of products Under the Selected category
                 * And also Provide The options for Add The Products 
                 * into the Purchase Table*/
                try
                    {
                List<Product> prds=new List<Product>();
                
                prds = _products;

                return View(prds);
                    }
                catch(SqlException ex)
                    {
                    ViewBag.Error = ex.Message;
                    return View();
                    }
                catch(Exception ex)
                    {
                    ViewBag.Error = ex.Message;
                    return View();
                    }
               


            }
        [HttpGet]
        public  ActionResult GetCategoryForUser()
            {
            try
                {
                
                List<Category> catergory =  _bigBazarBL.ShowAllCategoriesBL();
                return View(catergory);
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }


        [HttpGet]
        public ActionResult AddToCart(int productId)
            {
            /*This Action will add the product into the purchase
             * table until the receipt generation method has get called*/
            try
                {
                bool result = _bigBazarBL.AddToPurchaseListBL(productId, purchaseId);

                return RedirectToAction("SelectedPurchaseItems");
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
        [HttpGet]
        public ActionResult GenerateReceipt()
            {
            /*This will generate receipt by fetching the details
             * from purchase table and calculate the price
             * from that and return the corresponding receipt 
             * to the view*/
            try
                {
                reciept++;
                Receipt receipt = _bigBazarBL.GenerateReciptBL();
                receipt.ReceiptDate = System.DateTime.Now;
                receipt.ReceiptId = reciept;
                return View(receipt);
                }
            catch(ArithmeticException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(ReceiptGenerationFailedException ex)
                {
                ViewBag.Error = ex.Message;
                ViewBag.InnerException = ex.InnerException;
                return View();
                }
            catch(SqlException ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.Error = ex.Message;
                return View();
                }

            }
       







        }
    }
