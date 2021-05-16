﻿using AuthenticationMvcFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationMvcFramework.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Membership model )
            {
            using(var context = new StudentCapabilityDBEntities())
                {
                bool isValid = context.Users.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if(isValid)
                    {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Students");
                    }
                ModelState.AddModelError("", "Invalid username and password");
                return View();

                }
            }
        public ActionResult SignUp()
            {
            return View();
            }
        [HttpPost]
        public ActionResult SignUp(User model)
            {
            using(var context = new StudentCapabilityDBEntities())
                {
                context.Users.Add(model);
                context.SaveChanges();
                }
            return RedirectToAction("Login");

            }
        public ActionResult Logout()
            {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
            }
        }
}