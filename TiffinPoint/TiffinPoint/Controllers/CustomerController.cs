using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiffinPoint.Models;

namespace TiffinPoint.Controllers
{
    public class CustomerController : Controller
        {
        TiffinPointManagerModel customerManagerModel = new TiffinPointManagerModel();
        List<string> itemNames = new List<string>();
        List<int> itemIdList = new List<int>();

        // GET: Customer
        public ActionResult Index()
            {
            return View();
            }

        public List<string> AllItemNames()
            {
            List<ItemModel> items = customerManagerModel.GetAllItemsModel();
            foreach(ItemModel item in items)
                {
                itemNames.Add(item.ItemName);
                }
            return itemNames;
            }
        public List<int> AllItemIds()
            {
            List<ItemModel> items = customerManagerModel.GetAllItemsModel();
            foreach(ItemModel item in items)
                {
                itemIdList.Add(item.ItemId);
                }
            return itemIdList;
            }
        [HttpGet]
        public ActionResult AddCustomer()
            {
             ViewBag.itemIdList = AllItemIds();
            //ViewBag.ItemNames = AllItemNames();

            return View();
            }
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customerModel)
            {

            ViewBag.itemIdList = AllItemIds();

            //ViewBag.ItemNames = new SelectList( AllItemNames());
            // ViewBag.itemIdList = new SelectList( AllItemIds());
            try
                {
                if(ModelState.IsValid)
                    {
                    customerManagerModel.AddCustomersModel(customerModel);
                    ModelState.Clear();
                    return View();
                    }
                else
                    {
                    ModelState.AddModelError("", "error in saving data");
                    return View();

                    }
                }
            catch(Exception ex)
                {
                Console.WriteLine(ex.Message);
                return View();


                }
            }

        [HttpGet]
        public ActionResult GetCustomers()
            {
            try
                {

                return View(customerManagerModel.GetAllCustomersModel());
                }
            catch(Exception ex)
                {
                ViewBag(ex.Message);
                return View();
                }
            }
        [HttpGet]
        public ActionResult DeleteCustomer()
            {
            return View();

            }
        [HttpPost]
        public ActionResult DeleteCustomer(int id)
            {
            //int id = Convert.ToInt32(id1);
            try
                {
                if(ModelState.IsValid)
                    {
                    customerManagerModel.DeleteCustomerModel(id);
                    ModelState.Clear();
                    return RedirectToAction("Index");
                    }

                else
                    {
                    ModelState.AddModelError("", "error in saving data");
                    return RedirectToAction("Index");

                    }
                }
            catch
                {
                    return RedirectToAction("Index");


                }


            //return View(managerModel.DeleteCustomerModel(id));


            }
        }
}