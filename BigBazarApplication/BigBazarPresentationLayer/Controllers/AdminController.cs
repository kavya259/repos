using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigBazarEntities;
using BigBazarExceptionLayer;
using BigBazarBusinessLayer;
using BigBazarPresentationLayer.Models;
using Microsoft.Data.SqlClient;

namespace BigBazarPresentationLayer.Controllers
    {
    public class AdminController : Controller
        {
        //admin can add user ,delete user
        //can add category ,see category,delete category 
        public readonly IBigBazarBL _bigBazarBL;
        public AdminController(IBigBazarBL bigBazarBL)
            {
            this._bigBazarBL = bigBazarBL;
            }
        private BigBazarManagerModel managerModel = new BigBazarManagerModel();
        public ActionResult Index()
            {
            return View();
            }
        [HttpGet]
        public ActionResult AddCategory()
            {
            return View();
            }
        [HttpPost]
        public  ActionResult AddCategory(CategoryModel categoryModel)
            {
            try
                {
                if( _bigBazarBL.AddCategoryBL(managerModel.ModelToEntity(categoryModel)))
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
        public ActionResult GetAllCategories()
            {
            try
                {
                List<Category> catergories =  _bigBazarBL.ShowAllCategoriesBL();
                return View(catergories);
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


        //to delete category
        [HttpGet]
        public  ActionResult Deletecategory(int categoryId)
            {
            try
                {
                if( _bigBazarBL.DeleteCategoryBL(categoryId))
                    {
                    return RedirectToAction("ShowAllCategoriesBL", "Admin");
                    }
                return RedirectToAction("ShowAllCategoriesBL", "Admin");
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

        //public  IActionResult DeleteCategory(int id)
        //    {



        //    }

        }
    }
