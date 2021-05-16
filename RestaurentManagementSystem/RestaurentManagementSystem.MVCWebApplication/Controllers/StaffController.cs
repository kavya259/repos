using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurentManagementSystem.MVCWebApplication.Models;

namespace RestaurentManagementSystem.MVCWebApplication.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(StaffModel staffModel)
            {
            if(ModelState.IsValid)
                {
                staffModel.AddStaffManagerModel(staffModel);
                ModelState.Clear();
                return View();

                }
            else
                {
                ModelState.AddModelError("", "error in saving data");
                return View();
                }
            }

        }
}