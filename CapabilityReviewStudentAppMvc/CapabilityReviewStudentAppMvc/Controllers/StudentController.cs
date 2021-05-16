using CapabilityReviewStudentAppMvc.Models;
using StudentBusinessLayer;
using StudentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapabilityReviewStudentAppMvc.Controllers
{
    public class StudentController : Controller
        {
        ManagerModel managerModel = new ManagerModel();
        readonly IStudentBL studentBL = new StudentBL();

        // GET: Student
        public ActionResult Index()
            {
            return View();
            }
        [HttpGet]
        public ActionResult AddStudent()
            {

            var students = new List<Student>();
            students.Add(new Student() { Grade = 'a', Fee = 500 });
            students.Add(new Student() { Grade = 'b', Fee = 600 });
            students.Add(new Student() { Grade = 'c', Fee = 700 });

            ViewBag.list = students;

            return View();
            }
        [HttpPost]
        public ActionResult AddStudent(StudentModel studentModel)
            {

            var students = new List<Student>();
            students.Add(new Student() { Grade = 'a', Fee = 500 });
            students.Add(new Student() { Grade = 'b', Fee = 600 });
            students.Add(new Student() { Grade = 'c', Fee = 700 });

            ViewBag.list = students;

            try
                {
                if(ModelState.IsValid)
                    {
                    studentBL.AddStudentBL(managerModel.ModelToEntity(studentModel));
                    ModelState.Clear();
                    return View();
                    }
                else
                    {
                    ModelState.AddModelError("", "error in saving data");
                    return View();
                    }

                }
            catch(NullReferenceException ex)
                {
                ViewBag.error = ex.Message;
                return View();
                }
            catch(FormatException ex)
                {
                ViewBag.error = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.error = ex.Message;
                return View();
                }


            }

        [HttpGet]
        public ActionResult GetAllStudents()
            {
                {
                try
                    {
                    List<StudentModel> studentModels = managerModel.GetAllStudents_Model();
                    return View(studentModels);
                    }
                catch(NullReferenceException ex)
                    {
                    ViewBag.error = ex.Message;
                    return View();
                    }
                catch(Exception ex)
                    {
                    ViewBag.error = ex.Message;
                    return View();
                    }
                }


            }


        }

    }