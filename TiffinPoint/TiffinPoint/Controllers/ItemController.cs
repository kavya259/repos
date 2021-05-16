using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiffinPoint.Models;

namespace TiffinPoint.Controllers
{
    public class ItemController : Controller
    {
        TiffinPointManagerModel managerModel = new TiffinPointManagerModel();
        public ActionResult Index()
            {
            return View();
            }
        // GET: Item
        [HttpGet]
        public ActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItem(ItemModel itemModel)
            {
            try
                {
                if(ModelState.IsValid)
                    {
                    managerModel.AddItemsModel(itemModel);
                    ModelState.Clear();
                    return View();
                    }
                else
                    {
                    ModelState.AddModelError("", "error in saving data");
                    return View();

                    }
                }
            catch
                {
                return View();
                }
            }

        [HttpGet]
        public ActionResult GetItems()
            {
            return View(managerModel.GetAllItemsModel());
            }
    }
}