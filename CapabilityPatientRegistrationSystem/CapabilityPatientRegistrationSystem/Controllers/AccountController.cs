using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CapabilityPatientRegistrationSystem.Models;

namespace CapabilityPatientRegistrationSystem.Controllers
{
    public class AccountController : Controller
    {
        PatientRegisterEntities db = new PatientRegisterEntities();
        // GET: Account

        /// <summary>
        /// register method is to register new patients which can be done by patients
        /// registers with username and password
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
            {
            if(ModelState.IsValid)
                {
                db.Users.Add(user);
                if(db.SaveChanges() > 0)
                    {
                    return RedirectToAction("Login");
                    }
                }
            return View();
            }

        /// <summary>
        /// if user is present in database ,checks for it and logs in
        /// and redirects according to the role
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
            {
            return View();
            }
        [HttpPost]
        public ActionResult Login(User u,string ReturnUrl)
            {
            if(ModelState.IsValid)
                {
                var user = db.Users.Where(x => x.Username == u.Username && x.Password == u.Password).FirstOrDefault();
                if(user != null)
                    {
                    FormsAuthentication.SetAuthCookie(u.Username, false);
                    Session["uname"] = u.Username.ToString();

                    if(ReturnUrl != null)
                        {
                        return Redirect(ReturnUrl);
                        }
                    else
                        {
                        return RedirectToAction("Login");
                        }
                    }
                }
          
            return View();
            }


        public ActionResult Logout()
            {
            FormsAuthentication.SignOut();
            Session["uname"] = null;
            return View("Login");

            }


        }
}