using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcAuthenticationDemo.Models;

namespace MvcAuthenticationDemo.Controllers
{
    public class AccountController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Account
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
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
        public ActionResult Login()
            {
            return View();
            }
        [HttpPost]
        public ActionResult Login(User user,string ReturnUrl)
            {
           //  ReturnUrl ="%2fHome%2fContact";
            if(ModelState.IsValid)
                {
                var user1 = db.Users.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault();
               
                if(user1!=null)
                    {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    Session["uname"] = user.Username.ToString();
                    if(ReturnUrl != null)
                        {
                        return Redirect(ReturnUrl);
                        }
                    else
                        {
                        return RedirectToAction("Contact","Home");
                        }
                    }
                }
            return View();
            }
        public ActionResult Logout()
            {
            FormsAuthentication.SignOut();
            Session["uname"] = null;
            return Redirect("Login");
            }

        }
}