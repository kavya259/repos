using Excel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excel.Controllers
    {
    public class StudentController : Controller
        {
        List<Student> students = new List<Student>();
        public IActionResult Index()
            {
            return View(students);
            }

        //public IActionResult Index()
        //    {
        //    return View(students);
        //    }
        }
    }
