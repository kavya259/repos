using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapabilityPatientRegistrationSystem.Models;

namespace CapabilityPatientRegistrationSystem.Controllers
{
    public class PatientController : Controller
        {
        PatientRegisterEntities db = new PatientRegisterEntities();

        /// <summary>
        /// Add patient adds the patient to the database
        /// </summary>
        /// <returns>login page if successfully registered</returns>
        // GET: Patient
        [Authorize(Roles ="Patient")]
        public ActionResult AddPatient()
            {
            return View();
            }
        [HttpPost]
        [Authorize(Roles = "Patient")]
        public ActionResult AddPatient(Patient patient)
            {
            try
                {

                if(ModelState.IsValid)
                    {
                    db.Patients.Add(patient);
                    if(db.SaveChanges() == 0)
                        {
                        ViewBag.error = "registration of patient failed";
                        return View();
                        }
                    else
                        {
                        return RedirectToAction("Register", "Account");

                        }
                    }

                }
            catch(Exception ex)
                {
                ViewBag.error = ex.Message;
                }
            return View();

            }

        /// <summary>
        /// displays all patients upon successfull login and shows only to role authorizes(here role is doctor)
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Doctor")]
        [HttpGet]
        public ActionResult GetAllPatient()
            {
            if(ModelState.IsValid)
                {              
                var users=db.Patients.ToList();
                if(db.SaveChanges() == 0)
                    {
                    ViewBag.error = "No Patients";
                    return RedirectToAction("Register", "Account");
                    }
                else
                    {
                    return View(users);

                    }
                }
            return View();
            }
        [HttpGet]
        public ActionResult Qunit()
            {
            return View();
            }
        }
}