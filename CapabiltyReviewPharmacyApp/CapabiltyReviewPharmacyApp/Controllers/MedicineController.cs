using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PharmacyBusinessLayer;
using PharmacyExceptions;

namespace CapabiltyReviewPharmacyApp.Controllers
    {
    public class MedicineController : Controller
        {
        static readonly IPharmacyBL _pharmacy = new PharmacyBL();
        static List<Medicine> medicines = new List<Medicine>();
        static List<ManufacturingCompany> companies = new List<ManufacturingCompany>();
        static List<ManufacturingCompany> names = new List<ManufacturingCompany>();

        // GET: Medicine
        public ActionResult Index()
            {
            return View();
            }
        [HttpGet]
        public ActionResult AddMedicine()
            {
            foreach(ManufacturingCompany name in companies)
                {
                names.Add(name);
                }
            ViewBag.list = companies;


            return View();
            }
        [HttpPost]
        public ActionResult AddMedicine(Medicine medicine)
            {
            ViewBag.list = _pharmacy.GetAllCompaniesBL();

            try
                {
                if(ModelState.IsValid)
                    {
                    _pharmacy.AddMedicineBL(medicine);
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
                ViewBag.eror = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }
            }
        [HttpGet]
        public ActionResult AddManufacturer()
            {
            return View();
            }
        [HttpPost]
        public ActionResult AddManufacturer(ManufacturingCompany company)
            {
            try
                {
                if(ModelState.IsValid)
                    {
                    _pharmacy.AddManufacturerBL(company);
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
                ViewBag.eror = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }
            }


        [HttpGet]
        public ActionResult GetMedicines()
            {
            try
                {

                medicines = _pharmacy.GetAllMedicinesBL();
                return View(medicines);

                }
            catch(NullReferenceException ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }
            }
        [HttpGet]
        public ActionResult GetManufacturingCompanies()
            {
            try
                {

                companies = _pharmacy.GetAllCompaniesBL();
                return View(companies);

                }
            catch(NullReferenceException ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.eror = ex.Message;
                return View();
                }

            }

        }
    }