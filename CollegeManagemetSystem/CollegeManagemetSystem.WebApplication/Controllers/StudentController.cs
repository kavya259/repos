using CollegeManagemetSystem.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagemetSystem.WebApplication.Controllers
{
    public class StudentController : Controller
    {
        ManagerModel managerModel = new ManagerModel();
        // GET: Student
       

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

                }
            return View();

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

        [HttpGet]
        public ActionResult GetStudentMenu()
            {
            ViewBag.listOfStudentId = managerModel.GetAllStudentDetailsManagerModel();
            return View();
            }
        [HttpPost]
        public ActionResult GetStudentMenu(int studentid)
            {
            return RedirectToAction("GetStudentAge", new
                {
                studentid
                });
            }
       /* public ActionResult GetStudentAge(int studentid)
            {
            try
                {
                return View(managerModel.GetStudentAge(studentid));
                }
            catch(Exception ex)
                {
                return View(ex.Message);
                }
            }*/

        }
}