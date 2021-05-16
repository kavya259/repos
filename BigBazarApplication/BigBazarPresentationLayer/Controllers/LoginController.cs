using BigBazarPresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigBazarBusinessLayer;
using BigBazarEntities;
using BigBazarExceptionLayer;

namespace BigBazarPresentationLayer.Controllers
    {
    public class LoginController : Controller
        {
        public readonly IBigBazarBL _bigBazarBL;
        public LoginController(IBigBazarBL bigBazarBL)
            {
            this._bigBazarBL = bigBazarBL;
            }
        private BigBazarManagerModel managerModel = new BigBazarManagerModel();
        //new Registration

        [HttpGet]
        public IActionResult PersonRegister()
            {
            return View();
            }


        [HttpPost]
        public  IActionResult PersonRegister(UserModel userModel)
            {
            try
                {
                if( _bigBazarBL.AddUserBL(managerModel.ModelToEntity(userModel)))
                    {
                    return View();
                    }
                else
                    {
                    ViewBag.errorMessage = "Adding the user failed";
                    //return View();
                    return RedirectToAction("PersonRegister", "Login");

                    }
                }
            catch(RoleNotPermittedException ex)
                {
                ViewBag.errorMessage = ex.Message;
                return View();
                }
            catch(UserAlreadyExistsException ex)
                {
                ViewBag.errorMessage = ex.Message;
                return View();
                }
            catch(Exception ex)
                {
                ViewBag.errorMessage = ex.Message;
                return View();
                }

            }

      //login 
        [HttpGet]
        public IActionResult PersonLogin() 
            {
            return View();
            }
        [HttpPost]
        public IActionResult PersonLogin(UserModel userModel)
            {
            try
                {
                var userEntity = managerModel.ModelToEntity(userModel);

                if(_bigBazarBL.GetUserRoleBL(userEntity).Equals( "Admin"))
                    {
                    return RedirectToAction("Index", "Admin");
                    }
                else if(_bigBazarBL.GetUserRoleBL(userEntity).Equals( "User"))
                    {
                    return RedirectToAction("Index", "User");
                    }
                else
                    {
                    ViewBag.Login = "Wrong user name or Passwrd/ user does not exist";
                    return RedirectToAction("PersonRegister", "Login");
                    // return View();
                    }
                } 
            catch(Exception e)
                {
                ViewBag.userException = (e.Message);
                return View();
                }
            }


        [HttpGet]
        public ActionResult Logout()
            {
            return RedirectToAction("Index", "Home");

            }
        }
    }
 