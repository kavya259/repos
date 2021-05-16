using CollegeManagemetSystem.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagemetSystem.WebApplication.Controllers
    {
    public class HomeController : Controller
        {
        public ActionResult Index()
            {
            return View();
            }

        public ActionResult HomePage()
            {
            return View();
            }


        //**********************BRANCH CONTROLLER****************************************************
        ManagerModel managerModel = new ManagerModel();


        // GET: Branch
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
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



        //*****************************************************************************

        //*************************************Student controller*************************


        [HttpGet]
        public ActionResult DisplayAllStudents()
            {
            return View(managerModel.GetAllStudentDetailsManagerModel());
            }
        [HttpGet]
        public ActionResult AddStudent()
            {
            return View();
            }
        [HttpPost]
        public ActionResult AddStudent(StudentModel studentModel)
            {
            try
                {

                if(ModelState.IsValid)
                    {
                    managerModel.AddStudentDetailsManagerModel(studentModel);
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
        public ActionResult UpdateStudent()
            {
            return View();
            }


        [HttpPost]
        public ActionResult UpdateStudent(StudentModel studentModel)
            {

            if(ModelState.IsValid)
                {
                managerModel.UpdateStudentDetailsManagerModel(studentModel);
                ModelState.Clear();
                return View();
                }
            else
                {
                ModelState.AddModelError("", "error in saving data");
                return View();
                }
            }




        //************************************************************************************
        public ActionResult About()
            {
            ViewBag.Message = "Your application description page.";

            return View();
            }

        public ActionResult Contact()
            {
            ViewBag.Message = "Your contact page.";

            return View();
            }
        }
    }