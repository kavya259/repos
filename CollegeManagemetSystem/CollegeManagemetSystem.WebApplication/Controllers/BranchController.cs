using CollegeManagemetSystem.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagemetSystem.WebApplication.Controllers
{
    public class BranchController : Controller
    {
        ManagerModel managerModel = new ManagerModel();


        // GET: Branch
        //public ActionResult Index()
        //{
        //    return View();
        //}

       
        public ActionResult AddBranch()
            {
            return View();
            }
        [HttpPost]
        public ActionResult AddBranch(BranchModel branchModel)
            {

            if(ModelState.IsValid)
                {
                managerModel.AddBranchDetailsManagerModel(branchModel);
                ModelState.Clear();
                return View();
                }
            else
                {
                ModelState.AddModelError("", "error in saving data");
                return View();
                }
            }


        [HttpGet]
        public ActionResult DisplayAllBranches()
            {
            return View(managerModel.GetAllBranchDetailsManagerModel());
            }

        }
    }